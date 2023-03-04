
namespace SolarPanelAppWF
{
    partial class ModifyPriceForm
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
            this.BT_modify = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TB_name = new System.Windows.Forms.TextBox();
            this.TB_unitprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_modify
            // 
            this.BT_modify.Location = new System.Drawing.Point(81, 212);
            this.BT_modify.Name = "BT_modify";
            this.BT_modify.Size = new System.Drawing.Size(110, 23);
            this.BT_modify.TabIndex = 0;
            this.BT_modify.Text = "Modify unitprice";
            this.BT_modify.UseVisualStyleBackColor = true;
            this.BT_modify.Click += new System.EventHandler(this.BT_modify_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(495, 196);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(64, 110);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(188, 20);
            this.TB_name.TabIndex = 2;
            // 
            // TB_unitprice
            // 
            this.TB_unitprice.Location = new System.Drawing.Point(64, 158);
            this.TB_unitprice.Name = "TB_unitprice";
            this.TB_unitprice.Size = new System.Drawing.Size(188, 20);
            this.TB_unitprice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unitprice:";
            // 
            // ModifyPriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_unitprice);
            this.Controls.Add(this.TB_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BT_modify);
            this.Name = "ModifyPriceForm";
            this.Text = "ModifyPartForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModifyPriceForm_FormClosed);
            this.Load += new System.EventHandler(this.ModifyPriceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_modify;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TB_name;
        private System.Windows.Forms.TextBox TB_unitprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}