using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic_cut
{
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
            DisplayPresc();
            GetDocId();
            GetPatId();
            GetTestId();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Worship\OneDrive\Documents\clinic_db.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayPresc()
        {
            Con.Open();
            string Query = "Select * from PrescriptionTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PrescriptionDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            DocIdCb.SelectedIndex = 0;
            PatIdCb.SelectedIndex = 0;
            TestIdCb.SelectedIndex = 0;
            CostTb.Text = "";
            MedTb.Text = "";
            DocNameTb.Text = "";
            PatNameTb.Text = "";
            TestNameTb.Text = "";
            //Key = 0;
        }
        private void GetDocName()
        {
            Con.Open();
            string Query = "Select * from DoctorTbl where DocId=" + DocIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                DocNameTb.Text = dr["DocName"].ToString();
            }
            Con.Close();
        }
        private void GetPatName()
        {
            Con.Open();
            string Query = "Select * from PatientTbl where PatId=" + PatIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatNameTb.Text = dr["PatName"].ToString();
            }
            Con.Close();
        }
        private void GetTest()
        {
            Con.Open();
            string Query = "Select * from TestsTbl where TestNum=" + TestIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TestNameTb.Text = dr["TestName"].ToString();
                CostTb.Text = dr["TestCost"].ToString();
            }
            Con.Close();
        }
        private void GetDocId()
        {
            Con.Open();
            SqlCommand cmd= new SqlCommand("Select DocId from DoctorTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DocId", typeof(int));
            dt.Load(rdr);
            DocIdCb.ValueMember = "DocId";
            DocIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetPatId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select PatId from PatientTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatId", typeof(int));
            dt.Load(rdr);
            PatIdCb.ValueMember = "PatId";
            PatIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetTestId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select TestNum from TestsTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TestNum", typeof(int));
            dt.Load(rdr);
            TestIdCb.ValueMember = "TestNum";
            TestIdCb.DataSource = dt;
            Con.Close();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DocIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDocName();
        }

        private void PatIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPatName();
        }

        private void TestIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTest();
        }
        
        private void PrntBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DocNameTb.Text == "" || PatNameTb.Text == "" || TestNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PrescriptionTbl(DocId,DocName,PatId,PatName,LabTestId,LabTestName,Medicines,Cost)values(@DI,@DN,@PI,@PN,@TI,@TN,@Med,@Co)", Con);
                    cmd.Parameters.AddWithValue("@DI", DocIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DN", DocNameTb.Text);
                    cmd.Parameters.AddWithValue("@PI", PatIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PN", PatNameTb.Text);
                    cmd.Parameters.AddWithValue("@TI", TestIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@TN", TestNameTb.Text);
                    cmd.Parameters.AddWithValue("@Med", MedTb.Text);
                    cmd.Parameters.AddWithValue("@Co", CostTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Prescription Added");
                    Con.Close();
                    DisplayPresc();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PrescriptionDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrescSumTxt.Text = "";
            PrescSumTxt.Text = "                         CUT CLINIC\n\n"+"                       PRESCRIPTION                   "+"\n*****************************************************"+"\n" +DateTime.Today.Date+"\n\n\n\n        Doctor: "+ PrescriptionDGV.SelectedRows[0].Cells[2].Value.ToString()+"                  Patient: "+ PrescriptionDGV.SelectedRows[0].Cells[4].Value.ToString()+"\n\n\n                test: "+ PrescriptionDGV.SelectedRows[0].Cells[6].Value.ToString()+"    "+"       Medicines: "+ PrescriptionDGV.SelectedRows[0].Cells[7].Value.ToString() +"\n\n\n\n                      My CUT Clinic";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(PrescSumTxt.Text + "\n", new Font("Averia", 16, FontStyle.Regular), Brushes.Black, new Point(95, 80));
            e.Graphics.DrawString("\n\t" + "Thank You", new Font("Averia", 14, FontStyle.Bold), Brushes.Navy, new Point(200, 300));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Lab_tests Obj = new Lab_tests();
            Obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Patients Obj = new Patients();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Receptionist Obj = new Receptionist();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
            Obj.Show();
            this.Hide();
        }
    }
}
