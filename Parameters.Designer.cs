namespace ReportWizardPrototype
{
    partial class Parameters
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
            label6 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnCancel = new Button();
            button3 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(18, 22);
            label6.Name = "label6";
            label6.Size = new Size(268, 19);
            label6.TabIndex = 35;
            label6.Text = "Select Existing Parameter or Add New One";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnCancel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 367);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 55);
            panel1.TabIndex = 36;
            // 
            // button2
            // 
            button2.Location = new Point(338, 16);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 34;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(419, 16);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 33;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(574, 18);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(99, 325);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 42;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(18, 325);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 41;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "ServerName" });
            listBox1.Location = new Point(18, 60);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 259);
            listBox1.TabIndex = 40;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(324, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 44;
            textBox2.Text = "ServerName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 63);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 43;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 106);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 45;
            label2.Text = "Data Type:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "String", "Integer", "DataTime" });
            comboBox1.Location = new Point(324, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 23);
            comboBox1.TabIndex = 46;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 48;
            textBox1.Text = "MySQLServer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 149);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 47;
            label3.Text = "Testing Value:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Programmatic", "Interactive" });
            comboBox2.Location = new Point(324, 189);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(170, 23);
            comboBox2.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(232, 192);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 49;
            label4.Text = "Input Source:";
            // 
            // Parameters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(506, 422);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(label6);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Parameters";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Parameters";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button btnCancel;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
    }
}