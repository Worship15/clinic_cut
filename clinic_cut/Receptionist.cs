using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace clinic_cut
{
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
            DisplayRec();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Worship\OneDrive\Documents\clinic_db.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayRec()
        {
            Con.Open();
            string Query = "Select * from RecepTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ReceptionistDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
            private void AddBtn_Click(object sender, EventArgs e)
        {
            if (RNameTb.Text=="" || RPassword.Text=="" || RPhoneTb.Text=="" || RAddressTb.Text=="")
            {
                MessageBox.Show("Missing Information");
            }else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into RecepTable(RecepName,Recepphone,RecepAdd,RecepPass)values(@RN,@RP,@RA,@RPA)", Con);
                    cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@RA", RAddressTb.Text);
                    cmd.Parameters.AddWithValue("@RPA", RPassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist Added");
                    Con.Close();
                    DisplayRec();
                    Clear();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if(Key == 0)
            {
                MessageBox.Show("Select the customer to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from RecepTable where RecepId=@RKey", Con);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist Deleted");
                    Con.Close();
                    DisplayRec();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
      

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (RNameTb.Text == "" || RPassword.Text == "" || RPhoneTb.Text == "" || RAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update RecepTable set RecepName=@RN,RecepPhone=@RP,RecepAdd=@RA,RecepPass=@RPA where RecepId=@RKey",Con);
                    cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@RA", RAddressTb.Text);
                    cmd.Parameters.AddWithValue("@RPA", RPassword.Text);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist Updated");
                    Con.Close();
                    DisplayRec();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int Key = 0;
        private void ReceptionistDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            RNameTb.Text = ReceptionistDGV.SelectedRows[0].Cells[1].Value.ToString();
            RPhoneTb.Text = ReceptionistDGV.SelectedRows[0].Cells[2].Value.ToString();
            RAddressTb.Text = ReceptionistDGV.SelectedRows[0].Cells[3].Value.ToString();
            RPassword.Text = ReceptionistDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (RNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ReceptionistDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void Clear()
        {
            RNameTb.Text = "";
            RPassword.Text = "";
            RPhoneTb.Text = "";
            RAddressTb.Text = "";
            Key = 0;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Lab_tests Obj = new Lab_tests();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Doctors Obj = new Doctors();
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
            Home Obj = new Home();
            Obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
    
    
}
