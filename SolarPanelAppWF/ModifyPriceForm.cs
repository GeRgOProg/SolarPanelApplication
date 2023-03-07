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
    public partial class ModifyPriceForm : Form
    {
        private List<Part> parts = new List<Part>();

        public ModifyPriceForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updatePartList()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            parts = Controller.GetParts();
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Part name";
            dataGridView1.Columns[1].Name = "Unitprice";
            string[] rows = new string[parts.Count];
            int i = 0;
            foreach (var p in parts)
            {
                dataGridView1.Rows.Add(p.name, p.unitPrice);
            }

            DataGridViewRow row = dataGridView1.Rows[0];
            TB_name.Text = row.Cells[0].Value.ToString();
            TB_unitprice.Text = row.Cells[1].Value.ToString();
        }

        private void ModifyPriceForm_Load(object sender, EventArgs e)
        {
            updatePartList();
        }

        private void ModifyPriceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                TB_name.Text = row.Cells[0].Value.ToString();
                TB_unitprice.Text = row.Cells[1].Value.ToString();
            }
        }

        private void BT_modify_Click(object sender, EventArgs e)
        {
            try
            {
                string name = TB_name.Text;
                string unitprice = TB_unitprice.Text;
                Task<int> responsetask = Controller.modifyUnitPrice(name, unitprice);
                int responsecode = responsetask.Result;
                if (responsecode == 0)
                {
                    MessageBox.Show("Successful modification!");
                    
                    updatePartList();
                }
                else
                {
                    MessageBox.Show("Modification failed!");
                }
            }
            catch (FormatException)
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
