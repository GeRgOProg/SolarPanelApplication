
namespace SolarPanelAppWF
{
    partial class Login
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
            this.TB_username = new System.Windows.Forms.TextBox();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_login = new System.Windows.Forms.Button();
            this.BT_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_username
            // 
            this.TB_username.Location = new System.Drawing.Point(304, 94);
            this.TB_username.Name = "TB_username";
            this.TB_username.Size = new System.Drawing.Size(100, 20);
            this.TB_username.TabIndex = 0;
            this.TB_username.Text = "raktarvezeto";
            // 
            // TB_password
            // 
            this.TB_password.Location = new System.Drawing.Point(305, 135);
            this.TB_password.Name = "TB_password";
            this.TB_password.PasswordChar = '*';
            this.TB_password.Size = new System.Drawing.Size(100, 20);
            this.TB_password.TabIndex = 1;
            this.TB_password.Text = "raktarvezetopass";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // BT_login
            // 
            this.BT_login.Location = new System.Drawing.Point(316, 172);
            this.BT_login.Name = "BT_login";
            this.BT_login.Size = new System.Drawing.Size(75, 23);
            this.BT_login.TabIndex = 4;
            this.BT_login.Text = "LOGIN";
            this.BT_login.UseVisualStyleBackColor = true;
            this.BT_login.Click += new System.EventHandler(this.BT_login_Click);
            // 
            // BT_exit
            // 
            this.BT_exit.Location = new System.Drawing.Point(526, 131);
            this.BT_exit.Name = "BT_exit";
            this.BT_exit.Size = new System.Drawing.Size(75, 23);
            this.BT_exit.TabIndex = 5;
            this.BT_exit.Text = "Exit";
            this.BT_exit.UseVisualStyleBackColor = true;
            this.BT_exit.Click += new System.EventHandler(this.BT_exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 391);
            this.Controls.Add(this.BT_exit);
            this.Controls.Add(this.BT_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.TB_username);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_username;
        private System.Windows.Forms.TextBox TB_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_login;
        private System.Windows.Forms.Button BT_exit;
    }
}

