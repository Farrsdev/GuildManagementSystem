namespace Mdilearn
{
    partial class FormTreasury
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGuildBalance = new System.Windows.Forms.Label();
            this.lbLTax = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTransactionHistory = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guild Treasury";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblGuildBalance);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 141);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbLTax);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(443, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 141);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Guild Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tax Collected";
            // 
            // lblGuildBalance
            // 
            this.lblGuildBalance.AutoSize = true;
            this.lblGuildBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuildBalance.Location = new System.Drawing.Point(134, 64);
            this.lblGuildBalance.Name = "lblGuildBalance";
            this.lblGuildBalance.Size = new System.Drawing.Size(31, 32);
            this.lblGuildBalance.TabIndex = 3;
            this.lblGuildBalance.Text = "1";
            // 
            // lbLTax
            // 
            this.lbLTax.AutoSize = true;
            this.lbLTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLTax.Location = new System.Drawing.Point(160, 64);
            this.lbLTax.Name = "lbLTax";
            this.lbLTax.Size = new System.Drawing.Size(31, 32);
            this.lbLTax.TabIndex = 3;
            this.lbLTax.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTransactionHistory);
            this.groupBox1.Location = new System.Drawing.Point(12, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 207);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction History";
            // 
            // dgvTransactionHistory
            // 
            this.dgvTransactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionHistory.Location = new System.Drawing.Point(20, 31);
            this.dgvTransactionHistory.Name = "dgvTransactionHistory";
            this.dgvTransactionHistory.RowHeadersWidth = 51;
            this.dgvTransactionHistory.RowTemplate.Height = 24;
            this.dgvTransactionHistory.Size = new System.Drawing.Size(728, 150);
            this.dgvTransactionHistory.TabIndex = 5;
            // 
            // FormTreasury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormTreasury";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Guild Treasury";
            this.Load += new System.EventHandler(this.FormTreasury_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGuildBalance;
        private System.Windows.Forms.Label lbLTax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTransactionHistory;
    }
}