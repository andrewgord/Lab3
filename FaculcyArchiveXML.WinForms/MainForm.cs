using System.Data;

namespace FaculcyArchiveXML.WinForms
{
    public partial class MainForm : Form
    {
        private List<Material> generalMaterials;
        private List<Material> filteredMaterials;
        private string jsonFilePath = string.Empty;

        private JsonProcessor processor;

        public MainForm()
        {
            InitializeComponent();

            this.generalMaterials = new List<Material>();
            this.filteredMaterials = new List<Material>();
        }

        private void ClearAllControls()
        {
            this.dataGridView1.Rows.Clear();
            this.generalMaterials.Clear();
            this.filteredMaterials.Clear();

            this.authorsComboBox.Items.Clear();
            this.faculcyComboBox.Items.Clear();
            this.departamentComboBox.Items.Clear();

            this.authorsComboBox.SelectedIndex = -1;
            this.faculcyComboBox.SelectedIndex = -1;
            this.departamentComboBox.SelectedIndex = -1;

            this.authorsComboBox.Text = string.Empty;
            this.faculcyComboBox.Text = string.Empty;
            this.departamentComboBox.Text = string.Empty;
        }
        private void LoadDataFromJSON(string filePath)
        {
            processor = new JsonProcessor(filePath);
            var dataFromJsonFIle = processor.GetAllMaterials();
            this.idInsertPretifiedMaterialsIntoGrid(dataFromJsonFIle, isGeneralLoading: true);

        }

        private void idInsertPretifiedMaterialsIntoGrid(List<Material> materials, bool isGeneralLoading = false)
        {
            if (isGeneralLoading)
            {
                this.generalMaterials = materials;
            }

            dataGridView1.Rows.Clear();
            foreach (var material in materials)
            {
                string[] rowValues = new string[] {
                    material.Id.ToString(),
                    material.Author,
                    material.Title,
                    material.FaculcyName,
                    material.Department,
                    material.MaterialType,
                    material.Volume,
                    material.CreationDate.ToString(),
                    "",
                    ""
                };
                dataGridView1.Rows.Add(rowValues);
            }
        }

        private void FillFilterData()
        {
            var authors = this.generalMaterials.Select(x => x.Author).Distinct().ToList();
            this.authorsComboBox.Items.Add(string.Empty);
            this.authorsComboBox.Items.AddRange(authors.ToArray());

            var faculcies = this.generalMaterials.Select(x => x.FaculcyName).Distinct().ToList();
            this.faculcyComboBox.Items.Add(string.Empty);
            this.faculcyComboBox.Items.AddRange(faculcies.ToArray());

            var departaments = this.generalMaterials.Select(x => x.Department).Distinct().ToList();
            this.departamentComboBox.Items.Add(string.Empty);
            this.departamentComboBox.Items.AddRange(departaments.ToArray());
        }

        private void authorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ProcessFiltering();
        }

        private void ProcessFiltering()
        {
            var author = authorsComboBox.SelectedItem?.ToString();
            var faculcy = faculcyComboBox.SelectedItem?.ToString();
            var departament = departamentComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(author) || !string.IsNullOrEmpty(faculcy) || !string.IsNullOrEmpty(departament))
            {
                this.filteredMaterials = this.generalMaterials
                    .Where(x =>
                        (string.IsNullOrEmpty(author) || x.Author == author) &&
                        (string.IsNullOrEmpty(faculcy) || x.FaculcyName == faculcy) &&
                        (string.IsNullOrEmpty(departament) || x.Department == departament))
                    .ToList();
            }
            else
            {
                this.filteredMaterials = this.generalMaterials;
            }

            this.idInsertPretifiedMaterialsIntoGrid(this.filteredMaterials);
        }

        private void faculcyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ProcessFiltering();
        }

        private void departamentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ProcessFiltering();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllControls();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.EnsureToClose();
        }

        private void EnsureToClose()
        {
            DialogResult result = MessageBox.Show("Чи дійсно ви хочете завершити роботу з програмою?", "Закриття", buttons: MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "JSON Files|*.json|All Files|*.*";
            openFileDialog.Title = "Select an JSON File";

            this.ClearAllControls();


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                jsonFilePath = openFileDialog.FileName;
                this.LoadDataFromJSON(openFileDialog.FileName);
                this.FillFilterData();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm(processor);
            addForm.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            this.UpdateGrid();
        }

        private void UpdateGrid()
        {
            this.ClearAllControls();
            this.LoadDataFromJSON(jsonFilePath);
            FillFilterData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ClearAllControls();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedId = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                var editForm = new EditForm(processor, selectedId);
                editForm.ShowDialog();
            }
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                processor.DeleteMaterial(Convert.ToInt32(selectedId));
                MessageBox.Show($"Material with ID = {selectedId} has been deleted");
            }
            this.UpdateGrid();
        }
    }
}
