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
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double price = 0;
            double priceKids = 2.50;
            if (rb2nd.Checked)
            {
                price = 53;
            }
            else
            {
                price = 87.46;
            }
            double tickets = int.Parse(txtTickets.Text);
            double kids = int.Parse(txtKids.Text);
            double totalPrice = tickets * price + kids * priceKids;
            txtResult.Text = totalPrice.ToString("0.00");

        }
    }
}
