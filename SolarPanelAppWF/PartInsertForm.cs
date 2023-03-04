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
    public partial class PartInsertForm : Form
    {
        public PartInsertForm()
        {
            InitializeComponent();
        }

        private void PartInsertForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            try
            {
                if (TB_name.Text == "" || TB_unitprice.Text == "" || TB_currentstock.Text == "" || TB_maximumstorage.Text == "")
                {
                    MessageBox.Show("Please fill in all of the fields!");
                }
                else 
                { 
                    string name = TB_name.Text;
                    double unitprice = Convert.ToDouble(TB_unitprice.Text);
                    int currentstock = Convert.ToInt32(TB_currentstock.Text);
                    int maximumstorage = Convert.ToInt32(TB_maximumstorage.Text);

                    Task<int> responseCode = Controller.InsertPart(name, unitprice, currentstock, maximumstorage);
                    int code = responseCode.Result;

                    if (responseCode.Result == 0)
                    {
                        MessageBox.Show("Insertion successfull!");
                        TB_name.Text = "";
                        TB_unitprice.Text = "";
                        TB_currentstock.Text = "";
                        TB_maximumstorage.Text = "";
                    }
                }

            }

            catch(FormatException)
            {
                MessageBox.Show("Not sufficient formatting!");
            }
        }

        private void BT_homepage_Click(object sender, EventArgs e)
        {
            HomeForm homeform = new HomeForm();
            this.Hide();
            homeform.Show();
        }
    }
}
