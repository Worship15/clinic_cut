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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
            DisplayPat();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Worship\OneDrive\Documents\clinic_db.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayPat()
        {
            Con.Open();
            string Query = "Select * from PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PatientsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        int Key = 0;
        private void Clear()
        {
            PatNameTb.Text = "";
            PatGenCb.SelectedIndex = 0;
            PatHIVCb.SelectedIndex = 0;
            PatAddTb.Text = "";
            PatPhoneTb.Text = "";
            PatAlTb.Text = "";
            Key = 0;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (PatNameTb.Text == "" || PatAlTb.Text == "" || PatAddTb.Text == "" || PatPhoneTb.Text == "" || PatGenCb.SelectedIndex == -1 || PatHIVCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PatientTbl(PatName,PatDOB,PatGEN,PatPHONE,PatADD,PatAll,PatHIV)values(@PN,@PD,@PG,@PP,@PA,@PAl,@PH)", Con);
                    cmd.Parameters.AddWithValue("@PN", PatNameTb.Text);
                    cmd.Parameters.AddWithValue("@PD", PatDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PG", PatGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PP", PatPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@PA", PatAddTb.Text);
                    cmd.Parameters.AddWithValue("@PAl", PatAlTb.Text);
                    cmd.Parameters.AddWithValue("@PH", PatHIVCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Added");
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Patients_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            if (PatNameTb.Text == "" || PatAlTb.Text == "" || PatAddTb.Text == "" || PatPhoneTb.Text == "" || PatGenCb.SelectedIndex == -1 || PatHIVCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update PatientTbl set PatName=@PN,PatDOB=@PD,PatGEN=@PG,PatPHONE=@PP,PatADD=@PA,PatAll=@PAl,PatHIV=@PH where PatId = @PKey", Con);
                    cmd.Parameters.AddWithValue("@PN", PatNameTb.Text);
                    cmd.Parameters.AddWithValue("@PD", PatDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PG", PatGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PP", PatPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@PA", PatAddTb.Text);
                    cmd.Parameters.AddWithValue("@PAl",PatAlTb.Text);
                    cmd.Parameters.AddWithValue("@PH", PatHIVCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Updated");
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PatientsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatNameTb.Text = PatientsDGV.SelectedRows[0].Cells[1].Value.ToString();
            PatGenCb.SelectedItem = PatientsDGV.SelectedRows[0].Cells[2].Value.ToString();
            PatDOB.Text = PatientsDGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAddTb.Text = PatientsDGV.SelectedRows[0].Cells[4].Value.ToString();
            PatPhoneTb.Text = PatientsDGV.SelectedRows[0].Cells[5].Value.ToString();
            PatHIVCb.SelectedItem = PatientsDGV.SelectedRows[0].Cells[6].Value.ToString();
            PatAlTb.Text = PatientsDGV.SelectedRows[0].Cells[7].Value.ToString();
            if (PatNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PatientsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {

            if (Key == 0)
            {
                MessageBox.Show("Select the patient to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from PatientTbl where PatId=@PKey", Con);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Deleted");
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void HomeLbl_Click(object sender, EventArgs e)
        {
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Receptionist Obj = new Receptionist();
            Obj.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Lab_tests Obj = new Lab_tests();
            Obj.Show();
            this.Hide();
        }
    }
}
