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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Worship\OneDrive\Documents\clinic_db.mdf;Integrated Security=True;Connect Timeout=30");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            RoleCb.SelectedIndex = 0;
            UnameTb.Text = "";
            PassTb.Text = "";
        }
        public static string Role;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(RoleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Select Your Position");
            }else if(RoleCb.SelectedIndex == 0)
            {
                if(UnameTb.Text == "" || PassTb.Text == "")
                {
                    MessageBox.Show("Enter Both Admin Name and Password");

                }else if(UnameTb.Text == "Admin" && PassTb.Text == "Password")
                {
                    Role = "Admmin";
                    Patients Obj = new Patients();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Admin Name and Password");
                }
            }else if(RoleCb.SelectedIndex == 1)
            {
                if (UnameTb.Text == "" || PassTb.Text == "")
                {
                    MessageBox.Show("Enter Both Doctor Name and Password");
                }
                else 
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from DoctorTbl where DocName='" + UnameTb.Text + "' and DocPass='" + PassTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Doctor";
                        Prescription Obj = new Prescription();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Doctor not found");
                    }
                    Con.Close();
                }
              
                
            }
            else
            {
                if (UnameTb.Text == "" || PassTb.Text == "")
                {
                    MessageBox.Show("Enter Both Receptionist Name and Password");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from RecepTable where RecepName='" + UnameTb.Text + "' and RecepPass='" + PassTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Receptionist";
                        Home Obj = new Home();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Receptionist not found");
                    }
                    Con.Close();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
