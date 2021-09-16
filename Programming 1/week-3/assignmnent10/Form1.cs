using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignmnent10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            string value1 = txtS.Text;
            int salary = int.Parse(value1);

            double raise = salary * 0.05;
            double newsalary = salary + raise;

            lblRaise.Text = raise.ToString("0.00");
            lblNew.Text = newsalary.ToString("0.00");
        }
    }
}
