using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        void addition()
        {
            int x = Int32.Parse(txtNr1.Text);
            int y = Int32.Parse(txtNr2.Text);
            int sum = x + y;
            lblResult.Text = sum.ToString();
        }
        void substraction()
        {
            int x = Int32.Parse(txtNr1.Text);
            int y = Int32.Parse(txtNr2.Text);
            int dif = x - y;
            lblResult.Text = dif.ToString();
        }
        void multiplication()
        {
            int x = Int32.Parse(txtNr1.Text);
            int y = Int32.Parse(txtNr2.Text);
            int product = x * y;
            lblResult.Text = product.ToString();
        }
        void division()
        {
            double x = Int32.Parse(txtNr1.Text);
            double y = Int32.Parse(txtNr2.Text);
            double div = x / y;
            lblResult.Text = div.ToString("0.000");
        }
        private void BtnPlus_Click(object sender, EventArgs e)
        {
            addition();
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            substraction();
        }

        private void BtnInmultire_Click(object sender, EventArgs e)
        {
            multiplication();
        }

        private void BtnImpartire_Click(object sender, EventArgs e)
        {
            division();
        }
    }
}
