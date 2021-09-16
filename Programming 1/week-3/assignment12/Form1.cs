using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string value = txtAge.Text;
            double age = double.Parse(value);
            int price = 12;

            if (age < 5)
            {
                price = 0;
            }
            else if (age >= 5 && age <= 12)
            {
                price = price / 2;
            }
            else if (age >= 13 && age <= 54)
            {
                price = price;
            }
            else if (age > 55)
            {
                price = 0;
            }

            lblPrice.Text = price.ToString("$ 0.00");
        }
    }
}
