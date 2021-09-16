using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {   
            //read textbox and convert to double
            string value1 = txtCm.Text;
            double cm = double.Parse(value1);
            string value2 = txtKg.Text;
            double kg = double.Parse(value2);
            //calculate bmi, and normal weight
            double bmi = kg / ((cm / 100) * (cm / 100));
            double m1 = ((cm / 100) * (cm / 100)) * 20;
            double m2 = ((cm / 100) * (cm / 100)) * 25;
            //making normal bmi values constants 20-25(male)
            double x1 = 20;
            double x2 = 25;
            //display on labels
            lblBmi.Text = bmi.ToString("0.0");
            lblNormalbmi.Text = x1.ToString() + " .. " + x2.ToString();
            lblHealthy.Text = m1.ToString("0.0") + " .. " + m2.ToString("0.0");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //read textbox and convert to double
            string value1 = txtCm.Text;
            double cm = double.Parse(value1);
            string value2 = txtKg.Text;
            double kg = double.Parse(value2);
            //calculate bmi, and normal weight
            double bmi = kg / ((cm / 100) * (cm / 100));
            double f1 = ((cm / 100) * (cm / 100)) * 19;
            double f2 = ((cm / 100) * (cm / 100)) * 24;
            //making normal bmi values constants 19-24(female)
            double x1 = 19;
            double x2 = 24;
            //display on labels
            lblBmi.Text = bmi.ToString("0.0");
            lblNormalbmi.Text = x1.ToString() + " .. " + x2.ToString();
            lblHealthy.Text = f1.ToString("0.0") + " .. " + f2.ToString("0.0");
        }
    }
}
