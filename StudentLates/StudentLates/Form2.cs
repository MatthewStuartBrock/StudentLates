using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StudentLates
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        class CLsStudent
        {
            public int studentid { get; set; }
            public string studentname { get; set; }
        }


        private void btnaddNew_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = $"INSERT INTO tblStudent  (firstName,surName, StudentDOB) " +
                $"VALUES ('{txtfirstName.Text}' , '{txtsurName.Text}', '{dtpDoB.Value.Date}')";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            (Application.OpenForms["Form1"] as Form1).DisplayStudentData();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
                // list to hold the studetid and the student name
                List<CLsStudent> studentList = new List<CLsStudent>();
                clsDBConnector dbConnector = new clsDBConnector();
                OleDbDataReader dr;
                string sqlStr;
                dbConnector.Connect();
                sqlStr = "SELECT studentid, (surName & " + "', '" + "& firstname) as studentName From tblStudent";
                dr = dbConnector.DoSQL(sqlStr);
                // add all the students to the list
                while (dr.Read())
                {
                    studentList.Add(new CLsStudent { studentid = Convert.ToInt32(dr[0]), studentname = dr[1].ToString() });
                }
                // now bind the combo box to the list
                cmbStudentID.DisplayMember = "studentname";
                cmbStudentID.ValueMember = "studentid";
                cmbStudentID.DataSource = studentList;
                dbConnector.Close();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = "DELETE FROM tblStudent " +
                                $"WHERE (studentID = {cmbStudentID.SelectedValue})";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            (Application.OpenForms["Form1"] as Form1).DisplayStudentData();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

        }

        private void cmbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
