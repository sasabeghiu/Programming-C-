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
            //create an array with 6 random values
            int[] dice = new int[] { 0, 0, 0, 0, 0, 0 };
            Random random = new Random();
            for (int i = 0; i < 6000; i++)
            {
                int roll = random.Next(1, 7);
                switch (roll)
                {
                    case 1:
                        dice[0]++;
                        break;
                    case 2:
                        dice[1]++;
                        break;
                    case 3:
                        dice[2]++;
                        break;
                    case 4:
                        dice[3]++;
                        break;
                    case 5:
                        dice[4]++;
                        break;
                    case 6:
                        dice[5]++;
                        break;
                }
            }
            label7.Text = dice[0].ToString();
            label8.Text = dice[1].ToString();
            label9.Text = dice[2].ToString();
            label10.Text = dice[3].ToString();
            label11.Text = dice[4].ToString();
            label12.Text = dice[5].ToString();
        }
    }
}
