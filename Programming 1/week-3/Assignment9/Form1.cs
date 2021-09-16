using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            //make obj and convert
            string value1 = txtAge.Text;
            double age = double.Parse(value1);
            string value2 = txtMembership.Text;
            double membership = double.Parse(value2);
            int price;

            //prices for each sport
            if (radioFootball.Checked == true)
            {
                price = 175;
            }
            else
            {
                price = 225;
            }
            Console.ReadLine();

            //discount for 40+
            if (age > 40)
            {
                price = price - 25;
            }
            else if (membership > 10)
            {
                price = price - 20;
            }
            Console.ReadLine();

            //list
            lblFee.Text = price.ToString("$ 0.00");
        }
    }
}
