namespace Mdilearn
{
    partial class FormQuest
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtQuestCode = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReward = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxMonster = new System.Windows.Forms.ComboBox();
            this.cmbxStatus = new System.Windows.Forms.ComboBox();
            this.cmbxHunter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtQuestCode);
            this.groupBox2.Controls.Add(this.txtRes);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtReward);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbxMonster);
            this.groupBox2.Controls.Add(this.cmbxStatus);
            this.groupBox2.Controls.Add(this.cmbxHunter);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 204);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Tambah";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtQuestCode
            // 
            this.txtQuestCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuestCode.Enabled = false;
            this.txtQuestCode.Location = new System.Drawing.Point(132, 21);
            this.txtQuestCode.Name = "txtQuestCode";
            this.txtQuestCode.Size = new System.Drawing.Size(250, 22);
            this.txtQuestCode.TabIndex = 3;
            // 
            // txtRes
            // 
            this.txtRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRes.Location = new System.Drawing.Point(528, 23);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(203, 22);
            this.txtRes.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Quest Code";
            // 
            // txtReward
            // 
            this.txtReward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReward.Enabled = false;
            this.txtReward.Location = new System.Drawing.Point(528, 54);
            this.txtReward.Name = "txtReward";
            this.txtReward.Size = new System.Drawing.Size(202, 22);
            this.txtReward.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Result";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Reward Earned";
            // 
            // cmbxMonster
            // 
            this.cmbxMonster.FormattingEnabled = true;
            this.cmbxMonster.Items.AddRange(new object[] {
            "Forest",
            "Desert",
            "Volcano",
            "Snow",
            "Swamp",
            "Ocean",
            "Cave",
            "Sky"});
            this.cmbxMonster.Location = new System.Drawing.Point(132, 80);
            this.cmbxMonster.Name = "cmbxMonster";
            this.cmbxMonster.Size = new System.Drawing.Size(250, 24);
            this.cmbxMonster.TabIndex = 4;
            this.cmbxMonster.SelectedIndexChanged += new System.EventHandler(this.cmbxMonster_SelectedIndexChanged);
            // 
            // cmbxStatus
            // 
            this.cmbxStatus.FormattingEnabled = true;
            this.cmbxStatus.Items.AddRange(new object[] {
            "Pending",
            "Success",
            "Failed"});
            this.cmbxStatus.Location = new System.Drawing.Point(528, 82);
            this.cmbxStatus.Name = "cmbxStatus";
            this.cmbxStatus.Size = new System.Drawing.Size(202, 24);
            this.cmbxStatus.TabIndex = 4;
            this.cmbxStatus.SelectedIndexChanged += new System.EventHandler(this.cmbxStatuus_SelectedIndexChanged);
            // 
            // cmbxHunter
            // 
            this.cmbxHunter.FormattingEnabled = true;
            this.cmbxHunter.Items.AddRange(new object[] {
            "Forest",
            "Desert",
            "Volcano",
            "Snow",
            "Swamp",
            "Ocean",
            "Cave",
            "Sky"});
            this.cmbxHunter.Location = new System.Drawing.Point(132, 49);
            this.cmbxHunter.Name = "cmbxHunter";
            this.cmbxHunter.Size = new System.Drawing.Size(250, 24);
            this.cmbxHunter.TabIndex = 4;
            this.cmbxHunter.SelectedIndexChanged += new System.EventHandler(this.cmbxHunter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hunter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monster";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hunt Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quest Solo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 178);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // FormQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(806, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormQuest";
            this.Text = "FormQuest";
            this.Load += new System.EventHandler(this.FormQuest_Load);
            this.Shown += new System.EventHandler(this.FormQuest_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtReward;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxHunter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbxMonster;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtQuestCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbxStatus;
    }
}