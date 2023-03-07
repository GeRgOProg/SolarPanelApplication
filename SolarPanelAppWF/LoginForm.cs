using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolarPanelAppWF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BT_login_Click(object sender, EventArgs e)
        {
            string username = TB_username.Text;
            string password = TB_password.Text;

            string response=Controller.Login(username, password);
            User user = Controller.currentUser;
            if (user.roleName == "Raktárvezető" && response=="OK")
            {
                MessageBox.Show("Successful login as " + user.roleName + "!");
                this.Hide();
                HomeForm homeform=new HomeForm();
                homeform.Show();
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void BT_exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
