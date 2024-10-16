namespace StudentLates
{
    partial class Form1
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
            this.lstVStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.btnnewLateBasic = new System.Windows.Forms.Button();
            this.lstVLate = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVStudents
            // 
            this.lstVStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.firstName,
            this.surName,
            this.studentDOB});
            this.lstVStudents.HideSelection = false;
            this.lstVStudents.Location = new System.Drawing.Point(12, 12);
            this.lstVStudents.Name = "lstVStudents";
            this.lstVStudents.Size = new System.Drawing.Size(570, 421);
            this.lstVStudents.TabIndex = 0;
            this.lstVStudents.UseCompatibleStateImageBehavior = false;
            this.lstVStudents.View = System.Windows.Forms.View.Details;
            // 
            // studentID
            // 
            this.studentID.DisplayIndex = 3;
            this.studentID.Text = "Student ID";
            // 
            // firstName
            // 
            this.firstName.DisplayIndex = 0;
            this.firstName.Text = "First Name";
            // 
            // surName
            // 
            this.surName.DisplayIndex = 1;
            this.surName.Text = "Sur Name";
            // 
            // studentDOB
            // 
            this.studentDOB.DisplayIndex = 2;
            this.studentDOB.Text = "Date Of Birth";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnnewLateBasic
            // 
            this.btnnewLateBasic.Location = new System.Drawing.Point(155, 484);
            this.btnnewLateBasic.Name = "btnnewLateBasic";
            this.btnnewLateBasic.Size = new System.Drawing.Size(148, 23);
            this.btnnewLateBasic.TabIndex = 2;
            this.btnnewLateBasic.Text = "Add New Late (Basic)\r\n";
            this.btnnewLateBasic.UseVisualStyleBackColor = true;
            this.btnnewLateBasic.Click += new System.EventHandler(this.btnnewLateBasic_Click);
            // 
            // lstVLate
            // 
            this.lstVLate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lstVLate.HideSelection = false;
            this.lstVLate.Location = new System.Drawing.Point(721, 12);
            this.lstVLate.Name = "lstVLate";
            this.lstVLate.Size = new System.Drawing.Size(570, 421);
            this.lstVLate.TabIndex = 4;
            this.lstVLate.UseCompatibleStateImageBehavior = false;
            this.lstVLate.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 3;
            this.columnHeader6.Text = "Student ID";
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 0;
            this.columnHeader7.Text = "Period";
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 1;
            this.columnHeader8.Text = "Date";
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 2;
            this.columnHeader9.Text = "Minutes Late";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "FormV2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 761);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstVLate);
            this.Controls.Add(this.btnnewLateBasic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstVStudents);
            this.Name = "Form1";
            this.Text = "ljk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstVStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader surName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnnewLateBasic;
        private System.Windows.Forms.ListView lstVLate;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button button2;
    }
}

