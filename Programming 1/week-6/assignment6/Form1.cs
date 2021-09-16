using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void SquareByReference(ref int number)
        {
            number = Int32.Parse(txtNumber.Text);
            int reference = number * number;
            lblResult.Text = reference.ToString();
        }
        void SquareByReferenceOut(ref int number, out int square)
        {
            number = Int32.Parse(txtNumber.Text);
            square = number * number;
            lblResult.Text = square.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SquareByReference(number:);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            SquareByReferenceOut(out);
        }
    }
}
