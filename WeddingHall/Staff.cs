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

namespace WeddingHall
{
    public partial class Staff : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=MarriageDab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        List<TextBox> list = new List<TextBox>();
        int Staffkey = 0;
        public Staff()
        {

            InitializeComponent();

            list.Add(StaffNameTb);
            list.Add(StaffPhoneTb);
            list.Add(StaffPassTb);

        }
        private void clear()
        {
            StaffNameTb.Text = "";
            StaffPhoneTb.Text = "";
            Staffkey = 0;
            StaffGenderCb.SelectedIndex = -1;
            StaffPassTb.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Close();
                Con.Open();
                int x = list.Where(a => a.Text.Length == 0).Count();
                if (x != 0)
                {
                    throw new Exception("saasdsfs");
                }
                string query = "insert into StaffTbl values ('" + StaffNameTb.Text + "','" + StaffPhoneTb.Text + "','" + StaffGenderCb.SelectedItem.ToString() + "','" + StaffPassTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");

                populate();
                clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void populate()
        {
            Con.Open();
            string query = "select * from StaffTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StaffDGV.DataSource = ds.Tables[0];
            Con.Close();
            ;
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Staffkey == 0)
            {
                MessageBox.Show("Select the Staff to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Delete from StaffTbl where StaffId=" + Staffkey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Deleted Succesfully");
                    Con.Close();
                    populate();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void StaffDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.StaffDGV.Rows[e.RowIndex];
                StaffNameTb.Text = row.Cells["StaffName"].Value.ToString();
                StaffPhoneTb.Text = row.Cells["StaffPhone"].Value.ToString();
                StaffGenderCb.SelectedItem = row.Cells["StaffGender"].Value.ToString();
                StaffPassTb.Text = row.Cells["StaffPassword"].Value.ToString();
            }
            if (StaffNameTb.Text == "")
            {
                Staffkey = 0;
            }
            else
            {
                DataGridViewRow row = this.StaffDGV.Rows[e.RowIndex];
                Staffkey = Convert.ToInt32(row.Cells["StaffId"].Value.ToString());
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (StaffNameTb.Text == "" || StaffPhoneTb.Text == "" || StaffPassTb.Text == "" || StaffGenderCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Update StaffTbl set StaffName= '" + StaffNameTb.Text + "',StaffPhone='" + StaffPhoneTb.Text + "',StaffGender='" + StaffGenderCb.SelectedItem + "',StaffPassword='" + StaffPassTb.Text + "' where StaffId=" + Staffkey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Successfully Updated");
                    Con.Close();
                    populate();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void StaffGenderCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
