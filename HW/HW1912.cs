using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1912
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Button clicked!");
        }

        private void my_click(object sender, EventArgs e)
        {
            Debug.WriteLine("my clicked!");

            Random r = new Random();

            // answer to 1
            //int number = r.Next(1, 100);

            // this turns int ito a string
            //label1.Text = number.ToString();

            // answer to 2
            /*
            int lower = Convert.ToInt32( lowerLimitTxtBx.Text );
            int upper = Convert.ToInt32(upperLimitTxtBx.Text);
            int number = r.Next(lower, upper + 1);

            label1.Text = "The random number is : " + number;

            Debug.WriteLine("The random number is : " + number);
            Debug.WriteLine(lower);
            Debug.WriteLine(upper);
            */

            // answer to 5
            int lower, upper;
            bool succeesedLower = Int32.TryParse(lowerLimitTxtBx.Text, out lower);
            if (Int32.TryParse(lowerLimitTxtBx.Text, out lower) && Int32.TryParse(upperLimitTxtBx.Text, out upper))
            {
                int number = r.Next(lower, upper + 1);

                label1.Text = "The random number is : " + number;

            }
            else
            {
                label1.Text = "Wrong input .... I am not giving you a random number";
            }


        }

        private void zerofyBtn_Click(object sender, EventArgs e)
        {
            lowerLimitTxtBx.Text = 0.ToString();
            upperLimitTxtBx.Text = "0";

            label1.Text = "Zerofied!!";
        }
    }
}
