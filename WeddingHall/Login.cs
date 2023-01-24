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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=MarriageDab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            AdminLogin log = new AdminLogin();
            log.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UnameTb.Text==""||PasswordTb.Text=="")
            {
                MessageBox.Show("Enter Username and Password");
            }else
            {
                try
                {
                    Con.Open();
                    //SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from StaffTbl where StaffName='" + UnameTb.Text +"''" ,Con);
                    //string query = "select * from StaffTbl where StaffName=" + UnameTb.Text;
                    //SqlDataAdapter sda = new SqlDataAdapter(query, Con);

                    SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from StaffTbl where StaffName=' "+UnameTb.Text+" ' and StaffPassword=' "+PasswordTb.Text+" ' ",Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Columns[0].ToString() != "0")
                    {
                        MainForm home = new MainForm();
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password");
                        UnameTb.Text = "";
                        PasswordTb.Text = "";
                    }
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

           // Con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
