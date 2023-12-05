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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            if (Login.Role == "Receptionist")
            {
                RecepLbl.Enabled = false;
                DoctorLbl.Enabled = false;
                LabLbl.Enabled = false;
            }
            CountPatients();
            CountDoctors();
            CountLabTests();
            CountHIVPat();
            CountAsthmaPat();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Worship\OneDrive\Documents\clinic_db.mdf;Integrated Security=True;Connect Timeout=30");
        private void CountPatients()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PatientTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PatNumLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountHIVPat()
        {
            string Status = "Positive";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PatientTbl where PatHIV = '"+Status+"'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            HIVPatLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountAsthmaPat()
        {
            string Status = "Yes";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from PatientTbl where PatHIV = '" + Status + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AsPatLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountDoctors()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from DoctorTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DocNumLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountLabTests()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from TestsTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LabNumLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PatLbl_Click(object sender, EventArgs e)
        {
            Patients Obj = new Patients();
            Obj.Show();
            this.Hide();
        }

        private void RecepLbl_Click(object sender, EventArgs e)
        {
            Receptionist Obj = new Receptionist();
            Obj.Show();
            this.Hide();
        }

        private void DoctorLbl_Click(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
            Obj.Show();
            this.Hide();
        }

        private void LabLbl_Click(object sender, EventArgs e)
        {
            Lab_tests Obj = new Lab_tests();
            Obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
