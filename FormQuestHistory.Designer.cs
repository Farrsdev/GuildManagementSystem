namespace Mdilearn
{
    partial class FormQuestHistory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxHunter = new System.Windows.Forms.ComboBox();
            this.cmbxMonster = new System.Windows.Forms.ComboBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.chckDateFrom = new System.Windows.Forms.CheckBox();
            this.chckDateTo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chckDateTo);
            this.groupBox1.Controls.Add(this.chckDateFrom);
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Controls.Add(this.cmbxMonster);
            this.groupBox1.Controls.Add(this.cmbxHunter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quest History";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHistory);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(904, 342);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(3, 18);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.Size = new System.Drawing.Size(898, 321);
            this.dgvHistory.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(15, 155);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(104, 24);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(125, 155);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 24);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hunter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Monster";
            // 
            // cmbxHunter
            // 
            this.cmbxHunter.FormattingEnabled = true;
            this.cmbxHunter.Location = new System.Drawing.Point(9, 37);
            this.cmbxHunter.Name = "cmbxHunter";
            this.cmbxHunter.Size = new System.Drawing.Size(167, 24);
            this.cmbxHunter.TabIndex = 4;
            this.cmbxHunter.SelectedIndexChanged += new System.EventHandler(this.cmbxHunter_SelectedIndexChanged);
            // 
            // cmbxMonster
            // 
            this.cmbxMonster.FormattingEnabled = true;
            this.cmbxMonster.Location = new System.Drawing.Point(223, 37);
            this.cmbxMonster.Name = "cmbxMonster";
            this.cmbxMonster.Size = new System.Drawing.Size(167, 24);
            this.cmbxMonster.TabIndex = 4;
            this.cmbxMonster.SelectedIndexChanged += new System.EventHandler(this.cmbxMonster_SelectedIndexChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(421, 39);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(224, 22);
            this.dateFrom.TabIndex = 3;
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(667, 39);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(224, 22);
            this.dateTo.TabIndex = 3;
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // chckDateFrom
            // 
            this.chckDateFrom.AutoSize = true;
            this.chckDateFrom.Location = new System.Drawing.Point(421, 13);
            this.chckDateFrom.Name = "chckDateFrom";
            this.chckDateFrom.Size = new System.Drawing.Size(89, 20);
            this.chckDateFrom.TabIndex = 5;
            this.chckDateFrom.Text = "DateFrom";
            this.chckDateFrom.UseVisualStyleBackColor = true;
            this.chckDateFrom.CheckedChanged += new System.EventHandler(this.chckDateFrom_CheckedChanged);
            // 
            // chckDateTo
            // 
            this.chckDateTo.AutoSize = true;
            this.chckDateTo.Location = new System.Drawing.Point(667, 14);
            this.chckDateTo.Name = "chckDateTo";
            this.chckDateTo.Size = new System.Drawing.Size(75, 20);
            this.chckDateTo.TabIndex = 5;
            this.chckDateTo.Text = "DateTo";
            this.chckDateTo.UseVisualStyleBackColor = true;
            this.chckDateTo.CheckedChanged += new System.EventHandler(this.chckDateTo_CheckedChanged);
            // 
            // FormQuestHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 539);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQuestHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quest History";
            this.Load += new System.EventHandler(this.FormQuestHistory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.ComboBox cmbxMonster;
        private System.Windows.Forms.ComboBox cmbxHunter;
        private System.Windows.Forms.CheckBox chckDateTo;
        private System.Windows.Forms.CheckBox chckDateFrom;
    }
}