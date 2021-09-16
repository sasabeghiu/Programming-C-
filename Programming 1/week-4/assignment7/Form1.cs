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

        private void Button1_Click(object sender, EventArgs e)
        {
            lblSquare.Text = "";
            int l = Int32.Parse(txtNumber.Text);

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l; j++) 
                {
                    if ((i == 0 || j == 0) || (i == l - 1 || j == l - 1))
                    {
                        lblSquare.Text += "X ";
                    }
                    else
                    {
                        lblSquare.Text += "  ";
                    }
                }
                lblSquare.Text += "\n";
            }
        }
    }
}
