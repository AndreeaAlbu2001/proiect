using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeddingHall
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PassTb.Text=="")
            {
                MessageBox.Show("Enter the admin password");
            }
            else if(PassTb.Text=="Mycodespace")
            {
                Staff st = new Staff();
                st.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Wrong Password***Contact the admin of the system");
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
