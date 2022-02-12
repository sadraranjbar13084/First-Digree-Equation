using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Degree_equation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            lblabout.Text = "طراح و برنامه نویس: صدرا رنجبر" +
                "            " +
                "تاریخ : 2 فوریه 2022";
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            double num4 = (double)(num3.Value - num2.Value);
            double answer = num4 / (double)num1.Value;
            string answer2 = Convert.ToString(answer);
            txtanswer.Text = answer2;
        }
    }
}
