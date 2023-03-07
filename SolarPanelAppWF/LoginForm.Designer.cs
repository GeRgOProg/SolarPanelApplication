
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TB_username = new System.Windows.Forms.TextBox();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_login = new System.Windows.Forms.Button();
            this.BT_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_username
            // 
            this.TB_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TB_username.Location = new System.Drawing.Point(96, 59);
            this.TB_username.Name = "TB_username";
            this.TB_username.Size = new System.Drawing.Size(111, 23);
            this.TB_username.TabIndex = 0;
            this.TB_username.Text = "raktarvezeto";
            // 
            // TB_password
            // 
            this.TB_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TB_password.Location = new System.Drawing.Point(97, 100);
            this.TB_password.Name = "TB_password";
            this.TB_password.PasswordChar = '*';
            this.TB_password.Size = new System.Drawing.Size(110, 23);
            this.TB_password.TabIndex = 1;
            this.TB_password.Text = "raktarvezetopass";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(11, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // BT_login
            // 
            this.BT_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BT_login.Location = new System.Drawing.Point(345, 232);
            this.BT_login.Name = "BT_login";
            this.BT_login.Size = new System.Drawing.Size(92, 34);
            this.BT_login.TabIndex = 4;
            this.BT_login.Text = "LOGIN";
            this.BT_login.UseVisualStyleBackColor = true;
            this.BT_login.Click += new System.EventHandler(this.BT_login_Click);
            // 
            // BT_exit
            // 
            this.BT_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BT_exit.Location = new System.Drawing.Point(12, 12);
            this.BT_exit.Name = "BT_exit";
            this.BT_exit.Size = new System.Drawing.Size(78, 33);
            this.BT_exit.TabIndex = 5;
            this.BT_exit.Text = "Exit";
            this.BT_exit.UseVisualStyleBackColor = true;
            this.BT_exit.Click += new System.EventHandler(this.BT_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(73, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Please login!";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TB_username);
            this.panel1.Controls.Add(this.TB_password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(248, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 142);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label4.Location = new System.Drawing.Point(190, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Welcome in the Solar Panel System!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(536, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 391);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BT_exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BT_login);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

