
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartInsertForm));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(58, 49);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "UnitPrice:";
            // 
            // TB_name
            // 
            this.TB_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TB_name.Location = new System.Drawing.Point(130, 15);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(192, 23);
            this.TB_name.TabIndex = 3;
            // 
            // TB_unitprice
            // 
            this.TB_unitprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TB_unitprice.Location = new System.Drawing.Point(130, 46);
            this.TB_unitprice.Name = "TB_unitprice";
            this.TB_unitprice.Size = new System.Drawing.Size(192, 23);
            this.TB_unitprice.TabIndex = 4;
            // 
            // TB_currentstock
            // 
            this.TB_currentstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TB_currentstock.Location = new System.Drawing.Point(130, 85);
            this.TB_currentstock.Name = "TB_currentstock";
            this.TB_currentstock.Size = new System.Drawing.Size(192, 23);
            this.TB_currentstock.TabIndex = 5;
            // 
            // TB_maximumstorage
            // 
            this.TB_maximumstorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TB_maximumstorage.Location = new System.Drawing.Point(130, 127);
            this.TB_maximumstorage.Name = "TB_maximumstorage";
            this.TB_maximumstorage.Size = new System.Drawing.Size(192, 23);
            this.TB_maximumstorage.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(31, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(3, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maximum/Storage:";
            // 
            // INSERT
            // 
            this.INSERT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.INSERT.Location = new System.Drawing.Point(332, 271);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(104, 30);
            this.INSERT.TabIndex = 9;
            this.INSERT.Text = "CONFIRM";
            this.INSERT.UseVisualStyleBackColor = true;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(540, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TB_name);
            this.panel1.Controls.Add(this.TB_unitprice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TB_currentstock);
            this.panel1.Controls.Add(this.TB_maximumstorage);
            this.panel1.Location = new System.Drawing.Point(175, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 172);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(283, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Please fill in the forms!";
            // 
            // PartInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 391);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.INSERT);
            this.Name = "PartInsertForm";
            this.Text = "PartInsertForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PartInsertForm_FormClosed);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}