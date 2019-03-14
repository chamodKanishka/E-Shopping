using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shopping
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "chamod")
            {
                if (textBox2.Text == "kanishka")
                {
                    MessageBox.Show("login success");
                    Home home = new Home();
                    home.Show();
                    this.Hide();


                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
