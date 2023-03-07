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

        private static Form activeForm = null;
        public HomeForm()
        {
            InitializeComponent();
        }

        private void openChildForm(Form childForm)
        {

            if (activeForm != null)
            {
                activeForm.Hide();
            }

                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelContent.Controls.Add(childForm);
                panelContent.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            
            
        }



        private void újAlkatrészFelvételeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new PartInsertForm());
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            openChildForm(new PartInsertForm());
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
            openChildForm(new PartInsertForm());
        }

        private void alkatrészÁránakMódosításaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ModifyPriceForm());
        }
    }
}
