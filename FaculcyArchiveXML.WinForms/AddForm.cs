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
    public partial class AddForm : Form
    {
        private readonly JsonProcessor processor;

        public AddForm(JsonProcessor processor)
        {
            InitializeComponent();
            this.processor = processor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var material = new Material()
            {
                Author = textBox1.Text,
                Title = textBox2.Text,
                FaculcyName = textBox3.Text,
                Department = textBox4.Text,
                MaterialType = textBox5.Text,
                Volume = textBox6.Text,
                CreationDate = dateTimePicker1.Value,
            };

            processor.AddMaterial(material);

            MessageBox.Show("Success! Click Update Button to refresh data!");
        }
    }
}
