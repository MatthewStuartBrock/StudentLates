using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StudentLates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayStudentData();
            DisplayLateData();
        }

        public void DisplayLateData()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT studentID, period, dateOfLate, minsLate FROM tblLate";
            dr = dbConnector.DoSQL(sqlStr);
            lstVLate.Items.Clear();
            while (dr.Read())
            {
                lstVLate.Items.Add(dr[0].ToString());
                lstVLate.Items[lstVLate.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstVLate.Items[lstVLate.Items.Count - 1].SubItems.Add(dr[2].ToString());
                lstVLate.Items[lstVLate.Items.Count - 1].SubItems.Add(dr[3].ToString());
            }
            dbConnector.Close();
        }

        public void DisplayStudentData()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT studentID, firstName, surName, studentDOB FROM tblStudent";
            dr = dbConnector.DoSQL(sqlStr);
            lstVStudents.Items.Clear();
            while (dr.Read())
            {
                lstVStudents.Items.Add(dr[0].ToString());
                lstVStudents.Items[lstVStudents.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstVStudents.Items[lstVStudents.Items.Count - 1].SubItems.Add(dr[2].ToString());
                lstVStudents.Items[lstVStudents.Items.Count - 1].SubItems.Add(dr[3].ToString());
            }
            dbConnector.Close();
        }

    
      


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 studentform = new Form2();
            studentform.Show();
        }

        private void btnnewLateBasic_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmStudentLatesV2 frmStudentLatesV2 = new frmStudentLatesV2();
            frmStudentLatesV2.Show();
        }
    }
}  
