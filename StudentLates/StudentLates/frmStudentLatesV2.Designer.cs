namespace StudentLates
{
    partial class frmStudentLatesV2
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
            this.txtminsLate = new System.Windows.Forms.TextBox();
            this.lbltimeLate = new System.Windows.Forms.Label();
            this.lbldateOfLate = new System.Windows.Forms.Label();
            this.btnaddNew = new System.Windows.Forms.Button();
            this.dtpDoL = new System.Windows.Forms.DateTimePicker();
            this.lblperiod = new System.Windows.Forms.Label();
            this.lblstudentID = new System.Windows.Forms.Label();
            this.cmbStudentID = new System.Windows.Forms.ComboBox();
            this.cmbPeriod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtminsLate
            // 
            this.txtminsLate.Location = new System.Drawing.Point(338, 215);
            this.txtminsLate.Name = "txtminsLate";
            this.txtminsLate.Size = new System.Drawing.Size(100, 20);
            this.txtminsLate.TabIndex = 27;
            // 
            // lbltimeLate
            // 
            this.lbltimeLate.AutoSize = true;
            this.lbltimeLate.Location = new System.Drawing.Point(264, 215);
            this.lbltimeLate.Name = "lbltimeLate";
            this.lbltimeLate.Size = new System.Drawing.Size(68, 13);
            this.lbltimeLate.TabIndex = 26;
            this.lbltimeLate.Text = "Minutes Late";
            // 
            // lbldateOfLate
            // 
            this.lbldateOfLate.AutoSize = true;
            this.lbldateOfLate.Location = new System.Drawing.Point(263, 189);
            this.lbldateOfLate.Name = "lbldateOfLate";
            this.lbldateOfLate.Size = new System.Drawing.Size(69, 13);
            this.lbldateOfLate.TabIndex = 25;
            this.lbldateOfLate.Text = "Date of Late:";
            // 
            // btnaddNew
            // 
            this.btnaddNew.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnaddNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnaddNew.Location = new System.Drawing.Point(277, 278);
            this.btnaddNew.Name = "btnaddNew";
            this.btnaddNew.Size = new System.Drawing.Size(86, 40);
            this.btnaddNew.TabIndex = 24;
            this.btnaddNew.Text = "Add New";
            this.btnaddNew.UseVisualStyleBackColor = false;
            // 
            // dtpDoL
            // 
            this.dtpDoL.Location = new System.Drawing.Point(338, 189);
            this.dtpDoL.Name = "dtpDoL";
            this.dtpDoL.Size = new System.Drawing.Size(200, 20);
            this.dtpDoL.TabIndex = 23;
            // 
            // lblperiod
            // 
            this.lblperiod.AutoSize = true;
            this.lblperiod.Location = new System.Drawing.Point(292, 163);
            this.lblperiod.Name = "lblperiod";
            this.lblperiod.Size = new System.Drawing.Size(40, 13);
            this.lblperiod.TabIndex = 20;
            this.lblperiod.Text = "Period:";
            // 
            // lblstudentID
            // 
            this.lblstudentID.AutoSize = true;
            this.lblstudentID.Location = new System.Drawing.Point(275, 133);
            this.lblstudentID.Name = "lblstudentID";
            this.lblstudentID.Size = new System.Drawing.Size(58, 13);
            this.lblstudentID.TabIndex = 19;
            this.lblstudentID.Text = "Student ID";
            // 
            // cmbStudentID
            // 
            this.cmbStudentID.FormattingEnabled = true;
            this.cmbStudentID.Location = new System.Drawing.Point(338, 130);
            this.cmbStudentID.Name = "cmbStudentID";
            this.cmbStudentID.Size = new System.Drawing.Size(121, 21);
            this.cmbStudentID.TabIndex = 28;
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbPeriod.Location = new System.Drawing.Point(338, 160);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.Size = new System.Drawing.Size(121, 21);
            this.cmbPeriod.TabIndex = 29;
            // 
            // frmStudentLatesV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbPeriod);
            this.Controls.Add(this.cmbStudentID);
            this.Controls.Add(this.txtminsLate);
            this.Controls.Add(this.lbltimeLate);
            this.Controls.Add(this.lbldateOfLate);
            this.Controls.Add(this.btnaddNew);
            this.Controls.Add(this.dtpDoL);
            this.Controls.Add(this.lblperiod);
            this.Controls.Add(this.lblstudentID);
            this.Name = "frmStudentLatesV2";
            this.Text = "frmStudentLatesV2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtminsLate;
        private System.Windows.Forms.Label lbltimeLate;
        private System.Windows.Forms.Label lbldateOfLate;
        private System.Windows.Forms.Button btnaddNew;
        private System.Windows.Forms.DateTimePicker dtpDoL;
        private System.Windows.Forms.Label lblperiod;
        private System.Windows.Forms.Label lblstudentID;
        private System.Windows.Forms.ComboBox cmbStudentID;
        private System.Windows.Forms.ComboBox cmbPeriod;
    }
}