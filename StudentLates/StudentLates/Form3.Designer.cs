namespace StudentLates
{
    partial class Form3
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
            this.btnaddNew = new System.Windows.Forms.Button();
            this.dtpDoL = new System.Windows.Forms.DateTimePicker();
            this.txtperiod = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblperiod = new System.Windows.Forms.Label();
            this.lblstudentID = new System.Windows.Forms.Label();
            this.lbldateOfLate = new System.Windows.Forms.Label();
            this.txtminsLate = new System.Windows.Forms.TextBox();
            this.lbltimeLate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnaddNew
            // 
            this.btnaddNew.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnaddNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnaddNew.Location = new System.Drawing.Point(72, 169);
            this.btnaddNew.Name = "btnaddNew";
            this.btnaddNew.Size = new System.Drawing.Size(86, 40);
            this.btnaddNew.TabIndex = 13;
            this.btnaddNew.Text = "Add New";
            this.btnaddNew.UseVisualStyleBackColor = false;
            this.btnaddNew.Click += new System.EventHandler(this.btnaddNew_Click);
            // 
            // dtpDoL
            // 
            this.dtpDoL.Location = new System.Drawing.Point(133, 80);
            this.dtpDoL.Name = "dtpDoL";
            this.dtpDoL.Size = new System.Drawing.Size(200, 20);
            this.dtpDoL.TabIndex = 12;
            // 
            // txtperiod
            // 
            this.txtperiod.Location = new System.Drawing.Point(133, 54);
            this.txtperiod.Multiline = true;
            this.txtperiod.Name = "txtperiod";
            this.txtperiod.Size = new System.Drawing.Size(100, 20);
            this.txtperiod.TabIndex = 11;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(133, 24);
            this.txtStudentID.Multiline = true;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 10;
            // 
            // lblperiod
            // 
            this.lblperiod.AutoSize = true;
            this.lblperiod.Location = new System.Drawing.Point(87, 54);
            this.lblperiod.Name = "lblperiod";
            this.lblperiod.Size = new System.Drawing.Size(40, 13);
            this.lblperiod.TabIndex = 9;
            this.lblperiod.Text = "Period:";
            this.lblperiod.Click += new System.EventHandler(this.lblperiod_Click);
            // 
            // lblstudentID
            // 
            this.lblstudentID.AutoSize = true;
            this.lblstudentID.Location = new System.Drawing.Point(70, 24);
            this.lblstudentID.Name = "lblstudentID";
            this.lblstudentID.Size = new System.Drawing.Size(58, 13);
            this.lblstudentID.TabIndex = 8;
            this.lblstudentID.Text = "Student ID";
            // 
            // lbldateOfLate
            // 
            this.lbldateOfLate.AutoSize = true;
            this.lbldateOfLate.Location = new System.Drawing.Point(58, 80);
            this.lbldateOfLate.Name = "lbldateOfLate";
            this.lbldateOfLate.Size = new System.Drawing.Size(69, 13);
            this.lbldateOfLate.TabIndex = 16;
            this.lbldateOfLate.Text = "Date of Late:";
            // 
            // txtminsLate
            // 
            this.txtminsLate.Location = new System.Drawing.Point(133, 106);
            this.txtminsLate.Name = "txtminsLate";
            this.txtminsLate.Size = new System.Drawing.Size(100, 20);
            this.txtminsLate.TabIndex = 18;
            // 
            // lbltimeLate
            // 
            this.lbltimeLate.AutoSize = true;
            this.lbltimeLate.Location = new System.Drawing.Point(59, 106);
            this.lbltimeLate.Name = "lbltimeLate";
            this.lbltimeLate.Size = new System.Drawing.Size(68, 13);
            this.lbltimeLate.TabIndex = 17;
            this.lbltimeLate.Text = "Minutes Late";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtminsLate);
            this.Controls.Add(this.lbltimeLate);
            this.Controls.Add(this.lbldateOfLate);
            this.Controls.Add(this.btnaddNew);
            this.Controls.Add(this.dtpDoL);
            this.Controls.Add(this.txtperiod);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblperiod);
            this.Controls.Add(this.lblstudentID);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddNew;
        private System.Windows.Forms.DateTimePicker dtpDoL;
        private System.Windows.Forms.TextBox txtperiod;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblperiod;
        private System.Windows.Forms.Label lblstudentID;
        private System.Windows.Forms.Label lbldateOfLate;
        private System.Windows.Forms.TextBox txtminsLate;
        private System.Windows.Forms.Label lbltimeLate;
    }
}