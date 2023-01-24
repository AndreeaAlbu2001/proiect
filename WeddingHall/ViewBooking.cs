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
    public partial class ViewBooking : Form
    {
        public ViewBooking()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=MarriageDab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void populate()
        {
            Con.Open();
            string query = "select * from BookingTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }
        int Bookkey = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            string BookName = row.Cells["CustName"].Value.ToString();
            if (BookName == "CustName")
            {
                Bookkey = 0;
            }
            else
            {
                //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                Bookkey = Convert.ToInt32(row.Cells["BId"].Value.ToString());
            }


        }

        private void ViewBooking_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Bookkey == 0)
            {
                MessageBox.Show("Select the Booking to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Delete from BookingTbl where BId=" + Bookkey + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Deleted Succesfully");
                    Con.Close();
                    populate();
                    //clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
