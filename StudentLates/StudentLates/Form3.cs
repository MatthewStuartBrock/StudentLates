using System;
using System.Windows.Forms;

namespace StudentLates
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void lblperiod_Click(object sender, EventArgs e)
        {

        }

        private void btnaddNew_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = $"INSERT INTO tblLate  (StudentID, period, dateOfLate, minsLate) " +
                $"VALUES ('{txtStudentID.Text}' , '{txtperiod.Text}', '{dtpDoL.Value.Date}', '{txtminsLate.Text}')";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            this.Close();
            (Application.OpenForms["Form1"] as Form1).DisplayLateData();
        }
    }
}