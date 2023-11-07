namespace ReportWizardPrototype
{
    partial class MSSQLAdvancedProps
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
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(18, 9);
            label6.Name = "label6";
            label6.Size = new Size(260, 19);
            label6.TabIndex = 34;
            label6.Text = "Configure Advanced Connection Options";
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
            panel1.Size = new Size(478, 55);
            panel1.TabIndex = 35;
            // 
            // button2
            // 
            button2.Location = new Point(305, 16);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 34;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(386, 16);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 33;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // textBox1
            // 
            textBox1.Location = new Point(263, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 55;
            textBox1.Text = "3000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 105);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 54;
            label3.Text = "Value:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(263, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 23);
            textBox2.TabIndex = 53;
            textBox2.Text = "Timeout";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 54);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 52;
            label1.Text = "Name:";
            // 
            // button3
            // 
            button3.Location = new Point(99, 316);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 51;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(18, 316);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 50;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Timeout" });
            listBox1.Location = new Point(18, 51);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 259);
            listBox1.TabIndex = 49;
            // 
            // MSSQLAdvancedProps
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(478, 422);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MSSQLAdvancedProps";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MS SQL Connection";
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
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label1;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
    }
}