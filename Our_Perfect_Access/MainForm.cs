using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Our_Perfect_Access
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCreateDB_Click(object sender, EventArgs e)
        {

           

        }

        private void buttonChangeDB_Click(object sender, EventArgs e)
        {
            ChangeDbForm form = new ChangeDbForm();
            form.Show();
            this.Hide();
        }

        private void buttonEntries_Click(object sender, EventArgs e)
        {
            EntriesManipulationForm form = new EntriesManipulationForm();
            form.Show();
            this.Hide();
        }

        private void buttonQueries_Click(object sender, EventArgs e)
        {
            QueriesForm form = new QueriesForm();
            form.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
