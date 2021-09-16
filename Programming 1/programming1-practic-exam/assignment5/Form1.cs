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

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int distance = 0;
            if (radio5km.Checked)
            {
                distance = 5;
            }
            else if (radio10km.Checked)
            {
                distance = 10;
            }
            else
            {
                distance = 21;
            }

            int seconds = int.Parse(txtSec.Text);
            int minutes = int.Parse(txtMin.Text);
            int hours = int.Parse(txtHours.Text);
            double duration = hours + minutes / 60.0 + seconds / 3600;
            double speed = distance / duration;
            lblResult.Text = speed.ToString("0.000");
        }
    }
}
