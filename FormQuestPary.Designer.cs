namespace Mdilearn
{
    partial class FormQuestPary
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQCd = new System.Windows.Forms.TextBox();
            this.cmbxMonster = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.cmbxStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalReward = new System.Windows.Forms.TextBox();
            this.btnCreateParty = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 38);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quest Party";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quest Code";
            // 
            // txtQCd
            // 
            this.txtQCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQCd.Enabled = false;
            this.txtQCd.Location = new System.Drawing.Point(110, 74);
            this.txtQCd.Name = "txtQCd";
            this.txtQCd.Size = new System.Drawing.Size(209, 22);
            this.txtQCd.TabIndex = 11;
            // 
            // cmbxMonster
            // 
            this.cmbxMonster.FormattingEnabled = true;
            this.cmbxMonster.Location = new System.Drawing.Point(110, 112);
            this.cmbxMonster.Name = "cmbxMonster";
            this.cmbxMonster.Size = new System.Drawing.Size(209, 24);
            this.cmbxMonster.TabIndex = 12;
            this.cmbxMonster.SelectedIndexChanged += new System.EventHandler(this.cmbxMonster_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Monster";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hunter";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Location = new System.Drawing.Point(110, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 267);
            this.panel1.TabIndex = 13;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(203, 242);
            this.checkedListBox1.TabIndex = 0;
            // 
            // cmbxStatus
            // 
            this.cmbxStatus.FormattingEnabled = true;
            this.cmbxStatus.Items.AddRange(new object[] {
            "Success",
            "Pending",
            "Failed"});
            this.cmbxStatus.Location = new System.Drawing.Point(497, 74);
            this.cmbxStatus.Name = "cmbxStatus";
            this.cmbxStatus.Size = new System.Drawing.Size(230, 24);
            this.cmbxStatus.TabIndex = 14;
            this.cmbxStatus.SelectedIndexChanged += new System.EventHandler(this.cmbxStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hunt Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(497, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Reward";
            // 
            // txtTotalReward
            // 
            this.txtTotalReward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalReward.Enabled = false;
            this.txtTotalReward.Location = new System.Drawing.Point(497, 156);
            this.txtTotalReward.Name = "txtTotalReward";
            this.txtTotalReward.Size = new System.Drawing.Size(230, 22);
            this.txtTotalReward.TabIndex = 11;
            // 
            // btnCreateParty
            // 
            this.btnCreateParty.Location = new System.Drawing.Point(497, 210);
            this.btnCreateParty.Name = "btnCreateParty";
            this.btnCreateParty.Size = new System.Drawing.Size(230, 37);
            this.btnCreateParty.TabIndex = 16;
            this.btnCreateParty.Text = "Create Party";
            this.btnCreateParty.UseVisualStyleBackColor = true;
            this.btnCreateParty.Click += new System.EventHandler(this.btnCreateParty_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(497, 253);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(230, 37);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormQuestPary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCreateParty);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbxStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbxMonster);
            this.Controls.Add(this.txtTotalReward);
            this.Controls.Add(this.txtQCd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "FormQuestPary";
            this.Text = "FormQuestPary";
            this.Load += new System.EventHandler(this.FormQuestPary_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQCd;
        private System.Windows.Forms.ComboBox cmbxMonster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox cmbxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalReward;
        private System.Windows.Forms.Button btnCreateParty;
        private System.Windows.Forms.Button btnReset;
    }
}