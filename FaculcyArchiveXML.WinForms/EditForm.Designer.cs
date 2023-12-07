namespace FaculcyArchiveXML.WinForms
{
    partial class EditForm
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
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(136, 206);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 212);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 26;
            label7.Text = "Created at";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(136, 177);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 23);
            textBox6.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 185);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 24;
            label6.Text = "Volume";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(136, 148);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 156);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 22;
            label5.Text = "Material type";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(136, 119);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 127);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 20;
            label4.Text = "Departament";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 90);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 98);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 18;
            label3.Text = "Faculcy name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 69);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 16;
            label2.Text = "Title";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 40);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 14;
            label1.Text = "Author";
            // 
            // button1
            // 
            button1.Location = new Point(56, 255);
            button1.Name = "button1";
            button1.Size = new Size(280, 64);
            button1.TabIndex = 28;
            button1.Text = "Update!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 359);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label7;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}