
namespace SolarPanelAppWF
{
    partial class PartInsertForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.újAlkatrészFelvételeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alkatrészÁránakMódosításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.TB_unitprice = new System.Windows.Forms.TextBox();
            this.TB_currentstock = new System.Windows.Forms.TextBox();
            this.TB_maximumstorage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.INSERT = new System.Windows.Forms.Button();
            this.BT_homepage = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újAlkatrészFelvételeToolStripMenuItem,
            this.alkatrészÁránakMódosításaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(224, 48);
            // 
            // újAlkatrészFelvételeToolStripMenuItem
            // 
            this.újAlkatrészFelvételeToolStripMenuItem.Name = "újAlkatrészFelvételeToolStripMenuItem";
            this.újAlkatrészFelvételeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.újAlkatrészFelvételeToolStripMenuItem.Text = "Új alkatrész felvétele";
            // 
            // alkatrészÁránakMódosításaToolStripMenuItem
            // 
            this.alkatrészÁránakMódosításaToolStripMenuItem.Name = "alkatrészÁránakMódosításaToolStripMenuItem";
            this.alkatrészÁránakMódosításaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.alkatrészÁránakMódosításaToolStripMenuItem.Text = "Alkatrész árának módosítása";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 141);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "UnitPrice:";
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(348, 103);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(100, 20);
            this.TB_name.TabIndex = 3;
            // 
            // TB_unitprice
            // 
            this.TB_unitprice.Location = new System.Drawing.Point(348, 134);
            this.TB_unitprice.Name = "TB_unitprice";
            this.TB_unitprice.Size = new System.Drawing.Size(100, 20);
            this.TB_unitprice.TabIndex = 4;
            // 
            // TB_currentstock
            // 
            this.TB_currentstock.Location = new System.Drawing.Point(348, 173);
            this.TB_currentstock.Name = "TB_currentstock";
            this.TB_currentstock.Size = new System.Drawing.Size(100, 20);
            this.TB_currentstock.TabIndex = 5;
            // 
            // TB_maximumstorage
            // 
            this.TB_maximumstorage.Location = new System.Drawing.Point(348, 215);
            this.TB_maximumstorage.Name = "TB_maximumstorage";
            this.TB_maximumstorage.Size = new System.Drawing.Size(100, 20);
            this.TB_maximumstorage.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maximum/Storage:";
            // 
            // INSERT
            // 
            this.INSERT.Location = new System.Drawing.Point(325, 252);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(75, 23);
            this.INSERT.TabIndex = 9;
            this.INSERT.Text = "CONFIRM";
            this.INSERT.UseVisualStyleBackColor = true;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // BT_homepage
            // 
            this.BT_homepage.Location = new System.Drawing.Point(585, 252);
            this.BT_homepage.Name = "BT_homepage";
            this.BT_homepage.Size = new System.Drawing.Size(75, 23);
            this.BT_homepage.TabIndex = 10;
            this.BT_homepage.Text = "Homepage";
            this.BT_homepage.UseVisualStyleBackColor = true;
            this.BT_homepage.Click += new System.EventHandler(this.BT_homepage_Click);
            // 
            // PartInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 391);
            this.Controls.Add(this.BT_homepage);
            this.Controls.Add(this.INSERT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_maximumstorage);
            this.Controls.Add(this.TB_currentstock);
            this.Controls.Add(this.TB_unitprice);
            this.Controls.Add(this.TB_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PartInsertForm";
            this.Text = "PartInsertForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PartInsertForm_FormClosed);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem újAlkatrészFelvételeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alkatrészÁránakMódosításaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.TextBox TB_unitprice;
        private System.Windows.Forms.TextBox TB_currentstock;
        private System.Windows.Forms.TextBox TB_maximumstorage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.Button BT_homepage;
    }
}