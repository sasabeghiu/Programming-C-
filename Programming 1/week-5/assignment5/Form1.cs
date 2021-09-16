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
        private void Button1_Click(object sender, EventArgs e)
        {
            int val = int.Parse(txtComparasion.Text);
            for (int i = 0; i < listNumbers.Length; i++)
            {
                if (listNumbers[i] >= val)
                { 
                    listNumbers[i] = listNumbers[i] + 10;
                }
                else
                { 
                    listNumbers[i] = listNumbers[i] - 5;
                }
                lblAfter.Text += "Element " + i + " = " + listNumbers[i] + "\n";
            }
        }
        int[] listNumbers = new int[20];
        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < listNumbers.Length; i++)
            {
                listNumbers[i] = random.Next(0, 500);
                lblBefore.Text += "Element " + i + " = " + listNumbers[i] + "\n";
            }
        }
    }
}
