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
    public partial class Inheritance : Form
    {
        public Inheritance()
        {
            InitializeComponent();
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool IsValidForm()
        {
            bool isValid = true;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty(((TextBox)c).Text))
                    {
                        MessageBox.Show("Please fill all the fields");
                        isValid = false;
                        break;
                    }
                }
            }
            return isValid;
        }
        private void Inheritance_Load(object sender, EventArgs e)
        {
            //...
        }
    }
}
