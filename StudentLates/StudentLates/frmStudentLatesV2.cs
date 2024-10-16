using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StudentLates
{
    public partial class frmStudentLatesV2 : Form
    {
        class CLsStudent
        {
            public int studentid { get; set; }
            public string studentname { get; set; }
        }
        public frmStudentLatesV2()
        {
            InitializeComponent();
        }
        private void frmStudent_Load(object sender, EventArgs e)
        {
            List<CLsStudent> studentList = new List<CLsStudent>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT studentid, (surName & " + "', '" + "& firstname) as studentName From tblStudent";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                studentList.Add(new CLsStudent { studentid = Convert.ToInt32(dr[0]), studentname = dr[1].ToString() });
            }
            cmbStudentID.DisplayMember = "studentname";
            cmbStudentID.ValueMember = "studentid";
            cmbStudentID.DataSource = studentList;
            dbConnector.Close();

        }
        private void btnaddNew_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = $"INSERT INTO tblLate  (StudentID, period, dateOfLate, minsLate) " +
                $"VALUES ('{cmbStudentID.Text}' , '{cmbPeriod.Text}', '{dtpDoL.Value.Date}', '{txtminsLate.Text}')";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            this.Close();
            (Application.OpenForms["Form1"] as Form1).DisplayLateData();
        }

    }
}
