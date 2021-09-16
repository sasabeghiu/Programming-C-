using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Celsius2Kelvin()
        {
            int c = Int32.Parse(txtDegrees.Text);
            int conversion = c + 273;
            lblDegrees.Text = conversion.ToString("0.00");
        }
        void Celsius2Fahrenheit() 
        {
            int c = Int32.Parse(txtDegrees.Text);
            double conversion = (c * 9) / 5 + 32;
            lblDegrees.Text = conversion.ToString("0.00");
        }
        void Fahrenheit2Celsius()
        {
            int f = Int32.Parse(txtDegrees.Text);
            int conversion = (f - 32) * 5 / 9;
            lblDegrees.Text = conversion.ToString("0.00");
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Celsius2Kelvin();
            }
            else if (radioButton2.Checked == true)
            {
                Celsius2Fahrenheit();
            }
            else if (radioButton3.Checked == true)
            {
                Fahrenheit2Celsius();
            }
        }
    }
}
