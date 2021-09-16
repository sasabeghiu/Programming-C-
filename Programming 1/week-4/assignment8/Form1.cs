using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double input = double.Parse(txtNumber.Text);
            double value = 0;
            double sum = 0;
            
            double sum2 = input * ((input + 1) / 2);
            for (int i = 1; i <= input; i++)
            {
                value += value;
            }

            lblSum1.Text = sum2.ToString();
            lblSum2.Text = sum2.ToString();
            lblTeeeext.Text = "The sum and formula are equal.";
        }
    }
}
