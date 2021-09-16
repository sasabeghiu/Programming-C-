using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        const double StarWars = 12.50;
        const double Jumanji = 12.00;
        const double Penoza = 10.50;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            int age = int.Parse(txtAge.Text);
            double price = 0;
            if(rbMovie1.Checked)
            {
                price = StarWars;
            }
            else if (rbMovie2.Checked)
            {
                price = Jumanji;
            }
            else
            {
                price = Penoza;
            }

            if (age > 65)
            {
                price = price - (price * 0.25);
            }

            lblPrice.Text = price.ToString("0.00");
        }
    }
}
