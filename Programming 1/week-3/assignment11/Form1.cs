using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string value1 = txtNr1.Text;
            double nr1 = double.Parse(value1);
            string value2 = txtNr2.Text;
            double nr2 = double.Parse(value2);

            double average = (nr1 + nr2) / 2;
            double highest;

            if (nr2 > nr1)
            {
                highest = nr2;
            }
            else
            {
                highest = nr1;
            }

            double diff = highest - average;

            lblHigh.Text = highest.ToString();
            lblAverage.Text = average.ToString();
            lblDiff.Text = diff.ToString();
        }
    }
}
