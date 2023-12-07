namespace FaculcyArchiveXML.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            authorsComboBox = new ComboBox();
            faculcyComboBox = new ComboBox();
            departamentComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            FaculcyName = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            MaterialType = new DataGridViewTextBoxColumn();
            Volume = new DataGridViewTextBoxColumn();
            CreationDate = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            addButton = new Button();
            updateButton = new Button();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // authorsComboBox
            // 
            authorsComboBox.FormattingEnabled = true;
            authorsComboBox.Location = new Point(35, 407);
            authorsComboBox.Name = "authorsComboBox";
            authorsComboBox.Size = new Size(158, 23);
            authorsComboBox.TabIndex = 6;
            authorsComboBox.SelectedIndexChanged += authorsComboBox_SelectedIndexChanged;
            // 
            // faculcyComboBox
            // 
            faculcyComboBox.FormattingEnabled = true;
            faculcyComboBox.Location = new Point(35, 451);
            faculcyComboBox.Name = "faculcyComboBox";
            faculcyComboBox.Size = new Size(158, 23);
            faculcyComboBox.TabIndex = 7;
            faculcyComboBox.SelectedIndexChanged += faculcyComboBox_SelectedIndexChanged;
            // 
            // departamentComboBox
            // 
            departamentComboBox.FormattingEnabled = true;
            departamentComboBox.Location = new Point(35, 496);
            departamentComboBox.Name = "departamentComboBox";
            departamentComboBox.Size = new Size(158, 23);
            departamentComboBox.TabIndex = 8;
            departamentComboBox.SelectedIndexChanged += departamentComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 386);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 10;
            label1.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 433);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 11;
            label2.Text = "Faculcy name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 478);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 12;
            label3.Text = "Departament";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1073, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Author, Title, FaculcyName, Department, MaterialType, Volume, CreationDate, Edit, Delete });
            dataGridView1.Location = new Point(12, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1033, 314);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // FaculcyName
            // 
            FaculcyName.HeaderText = "FaculcyName";
            FaculcyName.Name = "FaculcyName";
            FaculcyName.ReadOnly = true;
            // 
            // Department
            // 
            Department.HeaderText = "Department";
            Department.Name = "Department";
            Department.ReadOnly = true;
            // 
            // MaterialType
            // 
            MaterialType.HeaderText = "MaterialType";
            MaterialType.Name = "MaterialType";
            MaterialType.ReadOnly = true;
            // 
            // Volume
            // 
            Volume.HeaderText = "Volume";
            Volume.Name = "Volume";
            Volume.ReadOnly = true;
            // 
            // CreationDate
            // 
            CreationDate.HeaderText = "CreationDate";
            CreationDate.Name = "CreationDate";
            CreationDate.ReadOnly = true;
            // 
            // Edit
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 128);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 128);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 255, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(128, 255, 128);
            Edit.DefaultCellStyle = dataGridViewCellStyle1;
            Edit.FlatStyle = FlatStyle.Flat;
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.ForeColor = Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = Color.DarkRed;
            Delete.DefaultCellStyle = dataGridViewCellStyle2;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // addButton
            // 
            addButton.Location = new Point(379, 427);
            addButton.Name = "addButton";
            addButton.Size = new Size(237, 57);
            addButton.TabIndex = 15;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(890, 386);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(155, 42);
            updateButton.TabIndex = 16;
            updateButton.Text = "UpdateButton";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(890, 434);
            button1.Name = "button1";
            button1.Size = new Size(155, 42);
            button1.TabIndex = 17;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 569);
            Controls.Add(button1);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(departamentComboBox);
            Controls.Add(faculcyComboBox);
            Controls.Add(authorsComboBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox authorsComboBox;
        private ComboBox faculcyComboBox;
        private ComboBox departamentComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button addButton;
        private Button updateButton;
        private Button button1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn FaculcyName;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn MaterialType;
        private DataGridViewTextBoxColumn Volume;
        private DataGridViewTextBoxColumn CreationDate;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}