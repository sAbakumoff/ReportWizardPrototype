﻿using System.Reflection;
using System.Windows.Forms;

namespace ReportWizardPrototype
{
    public partial class TableGroupings : Form
    {
        public event EventHandler BackClicked;
        public TableGroupings()
        {
            InitializeComponent();

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            var cols = new TableColumns();
            cols.ShowDialog(this);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void TableGroupings_Load(object sender, EventArgs e)
        {
            // listView1.SelectedIndices.Add(0);
            listBox1.SelectedIndex  = 0;
            btnMoveUp.Text = char.ConvertFromUtf32(8593);
            btnMoveDown.Text = char.ConvertFromUtf32(8595);
            comboBox1.SelectedIndex = comboBox2.SelectedIndex =  0;
        }
    }
}
