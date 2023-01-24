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
using ClassLibrary1;

namespace WeddingHall
{
    public partial class Booking : Inheritance
    {
        public Booking()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=MarriageDab;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public void SqlCommand(string query, SqlConnection Con)
        {
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //BeerPrice.Enabled = true;
            // BeerQty.Enabled = true;
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                BeerPrice.Enabled = true;
                BeerQty.Enabled = true;
            }
            else
            {
                BeerPrice.Enabled = false;
                BeerQty.Enabled = false;
                BeerQty.Text = "";
                BeerPrice.Text = "";
            }
        }

        private void SodaCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (SodaCheck.Checked == true)
            {
                SodaPrice.Enabled = true;
                SodaQty.Enabled = true;
            }
            else
            {
                SodaPrice.Enabled = false;
                SodaQty.Enabled = false;
                SodaQty.Text = "";
                SodaPrice.Text = "";
            }
        }

        private void WineCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (WineCheck.Checked == true)
            {
                WinePrice.Enabled = true;
                WineQty.Enabled = true;
            }
            else
            {
                WinePrice.Enabled = false;
                WineQty.Enabled = false;
                WineQty.Text = "";
                WinePrice.Text = "";
            }
        }

        private void WaterCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (WaterCheck.Checked == true)
            {
                WaterPrice.Enabled = true;
                WaterQty.Enabled = true;
            }
            else
            {
                WaterPrice.Enabled = false;
                WaterQty.Enabled = false;
                WaterQty.Text = "";
                WaterPrice.Text = "";
            }
        }

        private void JuiceCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (JuiceCheck.Checked == true)
            {
                JuicePrice.Enabled = true;
                JuiceQty.Enabled = true;
            }
            else
            {
                JuicePrice.Enabled = false;
                JuiceQty.Enabled = false;
                JuiceQty.Text = "";
                WaterPrice.Text = "";
            }
        }

        private void MottonCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (MottonCheck.Checked == true)
            {
                MottonPrice.Enabled = true;
                MottonQty.Enabled = true;
            }
            else
            {
                MottonPrice.Enabled = false;
                MottonQty.Enabled = false;
                MottonQty.Text = "";
                MottonPrice.Text = "";
            }
        }

        private void ChickenCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (ChickenCheck.Checked == true)
            {
                ChickenPrice.Enabled = true;
                ChickenQty.Enabled = true;
            }
            else
            {
                ChickenPrice.Enabled = false;
                ChickenQty.Enabled = false;
                ChickenQty.Text = "";
                ChickenPrice.Text = "";
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            int beer = 0, soda = 0, wine = 0, water = 0, juice = 0;
            if (checkBox1.Checked == true && BeerPrice.Text == "" && BeerQty.Text == "")
            {
                MessageBox.Show("Enter Beer Quantity");
            }
            else
            {
                beer = Convert.ToInt32(BeerPrice.Text) * Convert.ToInt32(BeerQty.Text);
            }

            if (SodaCheck.Checked == true && SodaPrice.Text == "" && SodaQty.Text == "")
            {
                MessageBox.Show("Enter Soda Quantity");
            }
            else
            {
                soda = Convert.ToInt32(SodaPrice.Text) * Convert.ToInt32(SodaQty.Text);
            }

            if (WineCheck.Checked == true && WinePrice.Text == "" && WineQty.Text == "")
            {
                MessageBox.Show("Enter Wine Quantity");
            }
            else
            {
                wine = Convert.ToInt32(WinePrice.Text) * Convert.ToInt32(WineQty.Text);
            }

            if (WaterCheck.Checked == true && WaterPrice.Text == "" && WaterQty.Text == "")
            {
                MessageBox.Show("Enter Water Quantity");
            }
            else
            {
                water = Convert.ToInt32(WaterPrice.Text) * Convert.ToInt32(WaterQty.Text);
            }

            if (JuiceCheck.Checked == true && JuicePrice.Text == "" && JuiceQty.Text == "")
            {
                MessageBox.Show("Enter Juice Quantity");
            }
            else
            {
                juice = Convert.ToInt32(JuicePrice.Text) * Convert.ToInt32(JuiceQty.Text);
            }

            int bevcost = beer + soda + wine + water + juice;
            BevCostLbl.Text = bevcost.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int motton = 0, chicken = 0, fish = 0, saucage = 0, biryani = 0;
            if (MottonCheck.Checked == true && MottonPrice.Text == "" && MottonQty.Text == "")
            {
                MessageBox.Show("Enter Motton Quantity");
            }
            else
            {
                motton = Convert.ToInt32(MottonPrice.Text) * Convert.ToInt32(MottonQty.Text);
            }

            if (ChickenCheck.Checked == true && ChickenPrice.Text == "" && ChickenQty.Text == "")
            {
                MessageBox.Show("Enter Chicken Quantity");
            }
            else
            {
                chicken = Convert.ToInt32(ChickenPrice.Text) * Convert.ToInt32(ChickenQty.Text);
            }

            if (FishCheck.Checked == true && FishPrice.Text == "" && FishQty.Text == "")
            {
                MessageBox.Show("Enter Wine Quantity");
            }
            else
            {
                fish = Convert.ToInt32(FishPrice.Text) * Convert.ToInt32(FishQty.Text);
            }

            if (SaucageCheck.Checked == true && SaucagePrice.Text == "" && SaucageQty.Text == "")
            {
                MessageBox.Show("Enter Saucage Quantity");
            }
            else
            {
                saucage = Convert.ToInt32(SaucagePrice.Text) * Convert.ToInt32(SaucageQty.Text);
            }

            if (BiryaniCheck.Checked == true && BiryaniPrice.Text == "" && BiryaniQty.Text == "")
            {
                MessageBox.Show("Enter Biryani Quantity");
            }
            else
            {
                biryani = Convert.ToInt32(BiryaniPrice.Text) * Convert.ToInt32(BiryaniQty.Text);
            }

            int dishcost = motton + chicken + fish + saucage + biryani;
            DishCostLbl.Text = dishcost.ToString();
        }
        private void GetCustId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CustId from CustomerTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(string));
            dt.Load(rdr);
            CustIdCb.ValueMember = "CustId";
            CustIdCb.DataSource = dt;
            Con.Close();
        }
        private void Booking_Load(object sender, EventArgs e)
        {
            GetCustId();
        }

        private void fetchcustName()
        {
            Con.Open();
            string mysql = "select * from CustomerTbl where CustId=" + CustIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Custnamelbl.Text = "" + dr["CustName"].ToString();
            }
            Con.Close();
        }
        private void CustIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchcustName();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           if(IsValidForm())
            {
                try
                {
                    Con.Open();
                    string food = "", drink = "";
                    // string beer="", soda="", wine="", water = "", juice ="", motton = "", chicken = "", fish = "", saucage = "", biryani = "";
                    if (MottonCheck.Checked == true)
                        food = food + "motton, ";
                    if (ChickenCheck.Checked == true)
                        food = food + "chicken, ";
                    if (FishCheck.Checked == true)
                        food = food + "fish, ";
                    if (SaucageCheck.Checked == true)
                        food = food + "saucage, ";
                    if (BiryaniCheck.Checked == true)
                        food = food + "biryani, ";

                    if (checkBox1.Checked == true)
                        drink = drink + "beer, ";
                    if (SodaCheck.Checked == true)
                        drink = drink + "soda, ";
                    if (WineCheck.Checked == true)
                        drink = drink + "wine, ";
                    if (WaterCheck.Checked == true)
                        drink = drink + "water, ";
                    if (JuiceCheck.Checked == true)
                        drink = drink + "juice, ";
                    string query = "insert into BookingTbl values('" + Convert.ToString(TimeCb.SelectedItem) + "','" + Custnamelbl.Text + "','" + Convert.ToInt32(NrPers.Text) + "','" + food + "','" + drink + "','" + Convert.ToInt32(BevCostLbl.Text) + "','" + Convert.ToInt32(DishCostLbl.Text) + "','" + Convert.ToInt32(OtherCharger.Text) + "','" + Convert.ToInt32(GrdTotal.Text) + "','" + Convert.ToInt32(Advance.Text) + "','" + Convert.ToInt32(Balance.Text) + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Added");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
                 
        }

        private void BackBt_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }

        private Class1 ob = new Class1();
        private int result = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(BevCostLbl.Text=="DrinkCost" || DishCostLbl.Text=="FoodCost")
            {
                MessageBox.Show("Calculate value for DrinkCost or FoodCost");
            }
            else
            { 
                int x1 = Convert.ToInt32(BevCostLbl.Text);
                int x2 = Convert.ToInt32(DishCostLbl.Text);
                result = ob.sum(x1, x2);
                GrdTotal.Text = result.ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (GrdTotal.Text=="0" || Advance.Text == "0")
            {
                MessageBox.Show("Calculate value for total price or advance");
            }
            else
            {
                int x1 = Convert.ToInt32(GrdTotal.Text);
                int x2 = Convert.ToInt32(Advance.Text);
                result = ob.dif(x1, x2);
                Balance.Text = result.ToString();

            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
