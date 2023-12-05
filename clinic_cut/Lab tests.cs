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
    public partial class Lab_tests : Form
    {
        public Lab_tests()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Worship\OneDrive\Documents\clinic_db.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayTest()
        {
            Con.Open();
            string Query = "Select * from TestsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            LabTestsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        int Key = 0;
        private void Clear()
        {
            LabTestTb.Text = "";
            LabCostTb.Text = "";
            Key = 0;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {


            if (LabCostTb.Text == "" || LabTestTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TestsTbl(TestName,TestCost)values(@TN,@TC)", Con);
                    cmd.Parameters.AddWithValue("@TN", LabTestTb.Text);
                    cmd.Parameters.AddWithValue("@TC", LabCostTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Added");
                    Con.Close();
                    DisplayTest();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LabTestsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                LabTestTb.Text = LabTestsDGV.SelectedRows[0].Cells[1].Value.ToString();
                LabCostTb.Text = LabTestsDGV.SelectedRows[0].Cells[2].Value.ToString();
             
                if (LabTestTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(LabTestsDGV.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            if (LabTestTb.Text == "" || LabCostTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update TestsTbl set TestName=@TN,TestCost=@TC where TestNum=@Tkey", Con);
                    cmd.Parameters.AddWithValue("@TN", LabTestTb.Text);
                    cmd.Parameters.AddWithValue("@TC", LabCostTb.Text);
                    cmd.Parameters.AddWithValue("@TKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Updated"); 
                    Con.Close();
                    DisplayTest();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {

            if (Key == 0)
            {
                MessageBox.Show("Select The Test");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from TestsTbl where TestNum=@TKey", Con);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Deleted");
                    Con.Close();
                    DisplayTest();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
