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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            button2.BackColor = DefaultBackColor;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.PapayaWhip;
            button1.BackColor = DefaultBackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
