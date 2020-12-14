using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Our_Perfect_Access
{
    public partial class EntriesManipulationForm : Form
    {
        public EntriesManipulationForm()
        {
            InitializeComponent();
        }

        private void EntriesManipulationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBackToMain_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }
    }
}
