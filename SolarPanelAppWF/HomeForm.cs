using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolarPanelAppWF
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void újAlkatrészFelvételeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartInsertForm partInsertForm = new PartInsertForm();
            this.Hide();
            partInsertForm.Show();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void kijelentkezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.currentUser = null;
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void újAlkatrészFelvételeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PartInsertForm partInsertForm = new PartInsertForm();
            this.Hide();
            partInsertForm.Show();
        }

        private void alkatrészÁránakMódosításaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyPriceForm modifyPriceForm = new ModifyPriceForm();
            this.Hide();
            modifyPriceForm.Show();
        }
    }
}
