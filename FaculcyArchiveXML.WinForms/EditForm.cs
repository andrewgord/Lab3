using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaculcyArchiveXML.WinForms
{
    public partial class EditForm : Form
    {
        private readonly JsonProcessor processor;
        private Material material;

        public EditForm(JsonProcessor processor, int updatedId)
        {
            InitializeComponent();
            this.processor = processor;

            this.material = processor.GetMaterialById(updatedId);

            this.textBox1.Text = material.Author;
            this.textBox2.Text = material.Title;
            this.textBox3.Text = material.FaculcyName;
            this.textBox4.Text = material.Department;
            this.textBox5.Text = material.MaterialType;
            this.textBox6.Text = material.Volume;
            this.dateTimePicker1.Value = material.CreationDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            material.Author = this.textBox1.Text;
            material.Title = this.textBox2.Text;
            material.FaculcyName = this.textBox3.Text;
            material.Department = this.textBox4.Text;
            material.MaterialType = this.textBox5.Text;
            material.Volume = this.textBox6.Text;
            material.CreationDate = this.dateTimePicker1.Value;

            processor.UpdateMaterial(material);
            MessageBox.Show("Success!");
        }
    }
}
