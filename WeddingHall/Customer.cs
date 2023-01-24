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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=MarriageDab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void button4_Click(object sender, EventArgs e)
        {
             if(CustNameTb.Text=="" || CustAddTb.Text=="" || CustPhoneTb.Text=="")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CustomerTbl values ('" + CustNameTb.Text + "','" + CustAddTb.Text + "','" + CustPhoneTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Added");
                    Con.Close();
                    populate();
                    clear();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            populate();
        }
        int custkey = 0;
        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*CustNameTb.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustAddTb.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
            CustPhoneTb.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();*/

            /*foreach(DataGridViewRow row in CustomerDGV.SelectedRows)
            {
                string value1 = row.Cells[1].Value.ToString();
                CustNameTb.Text = value1;
            }*/
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.CustomerDGV.Rows[e.RowIndex];
                CustNameTb.Text = row.Cells["CustName"].Value.ToString();
                CustAddTb.Text = row.Cells["CustAdd"].Value.ToString();
                CustPhoneTb.Text = row.Cells["CustPhone"].Value.ToString();
            }
            if(CustPhoneTb.Text=="")
            {
                custkey = 0;
            }else
            {
                DataGridViewRow row = this.CustomerDGV.Rows[e.RowIndex];
                custkey = Convert.ToInt32(row.Cells["CustId"].Value.ToString());
            }
        }
        private void clear()
        {
            CustPhoneTb.Text = "";
            CustAddTb.Text = "";
            custkey = 0;
            CustNameTb.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(custkey==0)
            {
                MessageBox.Show("Select the Customer to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Delete from CustomerTbl where CustId=" + custkey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Succesfully");
                    Con.Close();
                    populate();
                    clear();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CustNameTb.Text == "" || CustAddTb.Text == "" || CustPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Update CustomerTbl set CustName= '"+CustNameTb.Text+"',CustAdd='"+CustAddTb.Text+"',CustPhone='"+CustPhoneTb.Text+"' where CustId="+custkey+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Updated");
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
