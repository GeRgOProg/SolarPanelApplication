
namespace SolarPanelAppWF
{
    partial class HomeForm
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.újAlkatrészFelvételeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alkatrészÁránakMódosításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kijelentkezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(-1, 27);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(806, 430);
            this.panelContent.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újAlkatrészFelvételeToolStripMenuItem,
            this.alkatrészÁránakMódosításaToolStripMenuItem,
            this.kijelentkezésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // újAlkatrészFelvételeToolStripMenuItem
            // 
            this.újAlkatrészFelvételeToolStripMenuItem.Name = "újAlkatrészFelvételeToolStripMenuItem";
            this.újAlkatrészFelvételeToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.újAlkatrészFelvételeToolStripMenuItem.Text = "Register new part";
            this.újAlkatrészFelvételeToolStripMenuItem.Click += new System.EventHandler(this.újAlkatrészFelvételeToolStripMenuItem_Click_1);
            // 
            // alkatrészÁránakMódosításaToolStripMenuItem
            // 
            this.alkatrészÁránakMódosításaToolStripMenuItem.Name = "alkatrészÁránakMódosításaToolStripMenuItem";
            this.alkatrészÁránakMódosításaToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.alkatrészÁránakMódosításaToolStripMenuItem.Text = "Modifying part unitprice";
            this.alkatrészÁránakMódosításaToolStripMenuItem.Click += new System.EventHandler(this.alkatrészÁránakMódosításaToolStripMenuItem_Click);
            // 
            // kijelentkezésToolStripMenuItem
            // 
            this.kijelentkezésToolStripMenuItem.Name = "kijelentkezésToolStripMenuItem";
            this.kijelentkezésToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.kijelentkezésToolStripMenuItem.Text = "Logout";
            this.kijelentkezésToolStripMenuItem.Click += new System.EventHandler(this.kijelentkezésToolStripMenuItem_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "Solar Panel System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem újAlkatrészFelvételeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alkatrészÁránakMódosításaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kijelentkezésToolStripMenuItem;
    }
}