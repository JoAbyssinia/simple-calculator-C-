using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double fnum, snum, result;
        String opration;

        private void one_Click(object sender, EventArgs e)
        {
            int one = 1;
            String Enum = num_disp.Text + one;
            num_disp.Text = Enum;
            
        }

        private void two_Click(object sender, EventArgs e)
        {
            int two = 2;
            String Enum = num_disp.Text + two;
            num_disp.Text = Enum;

        }

        private void thr_Click(object sender, EventArgs e)
        {
            int thr = 3;
            String Enum = num_disp.Text + thr;
            num_disp.Text = Enum;
        }

        private void four_Click(object sender, EventArgs e)
        {
            int four= 4;
            String Enum = num_disp.Text + four;
            num_disp.Text = Enum;
        }
        private void five_Click(object sender, EventArgs e)
        {
            int five = 5;
            String Enum = num_disp.Text + five;
            num_disp.Text = Enum;
        }

        private void six_Click(object sender, EventArgs e)
        {
            int six = 6;
            String Enum = num_disp.Text + six;
            num_disp.Text = Enum;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            int seven = 7;
            String Enum = num_disp.Text + seven;
            num_disp.Text = Enum;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            int ght = 8;
            String Enum = num_disp.Text + ght;
            num_disp.Text = Enum;
        }

        private void ziro_Click(object sender, EventArgs e)
        {
            int ziro = 0;
            String Enum = num_disp.Text + ziro;
            num_disp.Text = Enum;
        }

        private void ngtv_Click(object sender, EventArgs e)
        {
            /* String min = num_disp.Text.Substring(0,1);
             if (min == "-")
             {
                 String Enum =num_disp.Text.Substring(1);
                 num_disp.Text = Enum;
             }
             else {
                 String Enum = "-"+num_disp.Text ;
                 num_disp.Text = Enum;
             }*/
            if (String.Compare(num_disp.Text,"") == 0){}
            else{
                String mins = num_disp.Text;
                double ops = Double.Parse(mins);
                ops = ops * (-1);
                num_disp.Text = Convert.ToString(ops);
            }
            
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (num_disp.Text == "") {
                num_disp.Text = "0";
            }
            int ch = num_disp.Text.IndexOf(".");
            if (ch == -1)
            {
                String Enum = num_disp.Text +".";
                num_disp.Text = Enum;
            }
            else {
                String Enum = num_disp.Text;
                num_disp.Text = Enum;
            }
            
        } private void nine_Click(object sender, EventArgs e)
        {
            int nine = 9;
            String Enum = num_disp.Text + nine;
            num_disp.Text = Enum;
        }

       

        private void clear_Click(object sender, EventArgs e)
        {
            num_disp.ForeColor = Color.Black;
            num_disp.Text="";
            calc_screen.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (String.Compare(num_disp.Text,"")==0)
            {
                num_disp.Text = "Error";
                num_disp.ForeColor = Color.Red;
            }else if (String.Compare(num_disp.Text,"Error")==0)
            {
                num_disp.Text = "Error";
                num_disp.ForeColor = Color.Red;
            }
            else if (calc_screen.Text !="")
            {
                String Enum = calc_screen.Text + "+";
                String num = calc_screen.Text;
                num_disp.Text = Enum;
                fnum = double.Parse(num);
                opration = "+";
                calc_screen.Text = "";
            }
            else {
                num_disp.ForeColor = Color.Black;
                String Enum = num_disp.Text + "+";
                String num = num_disp.Text;
                num_disp.Text = Enum;
                fnum = double.Parse(num);
                opration = "+";
            }
           
        }
        private void mins_Click(object sender, EventArgs e)
        {
            if (String.Compare(num_disp.Text, "") == 0)
            {
                num_disp.Text = "Error";
                num_disp.ForeColor = Color.Red;
            }
            else if (String.Compare(num_disp.Text, "Error") == 0)
            {
                num_disp.Text = "Error";
                num_disp.ForeColor = Color.Red;
            }
            else if (calc_screen.Text !="")
            {
                String Enum = calc_screen.Text + "-";
                String num = calc_screen.Text;
                num_disp.Text = Enum;
                fnum = double.Parse(num);
                opration = "-";
                calc_screen.Text = "";
            }
            else
            {
                String Enum = num_disp.Text + "-";
                String num = num_disp.Text;
                num_disp.Text = Enum;
                fnum = double.Parse(num);
                opration = "-";
            }
        }

        private void mult_Click(object sender, EventArgs e)
        {
            if (String.Compare(num_disp.Text, "") == 0)
            {
                num_disp.Text = "Error";
                num_disp.ForeColor = Color.Red;
            }
            else if (String.Compare(num_disp.Text, "Error") == 0)
            {
                num_disp.Text = "Error";
                num_disp.ForeColor = Color.Red;
            }
            else if (calc_screen.Text !="")
            {
                String Enum = calc_screen.Text + "×";
                String num = calc_screen.Text;
                num_disp.Text = Enum;
                fnum = double.Parse(num);
                opration = "*";
                calc_screen.Text = "";
            }
            else
            {
                String Enum = num_disp.Text + "×";
                String num = num_disp.Text;
                num_disp.Text = Enum;
                fnum = double.Parse(num);
                opration = "*";
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (String.Compare(num_disp.Text, "") == 0)
            {
                num_disp.Text = "Error";
                num_disp.ForeColor = Color.Red;
            }
            else if (String.Compare(num_disp.Text, "Error") == 0)
            {
                num_disp.Text = "Error";
                num_disp.ForeColor = Color.Red;
            }
            else if (calc_screen.Text != "")
            {
                String Enum = calc_screen.Text + "/";
                String num = calc_screen.Text;
                num_disp.Text = Enum;
                fnum = double.Parse(num);
                opration = "/";
                calc_screen.Text = "";
            }
            else
            {
                String Enum = num_disp.Text + "/";
                String num = num_disp.Text;
                num_disp.Text = Enum;
                fnum = double.Parse(num);
                opration = "/";
            }
        }

        private void remender_Click(object sender, EventArgs e)
        {
            if (String.Compare(num_disp.Text, "") == 0)
            {
                num_disp.Text = "Error";
                num_disp.ForeColor = Color.Red;
            }
            else if (String.Compare(num_disp.Text, "Error") == 0)
            {
                num_disp.Text = "Error";
                num_disp.ForeColor = Color.Red;
            }
            else if (calc_screen.Text !="") {
                String Enum = calc_screen.Text + "%";
                String num = calc_screen.Text;
                num_disp.Text = Enum;
                fnum = double.Parse(num);
                opration = "%";
                calc_screen.Text = "";
            }
            else
            {
                String Enum = num_disp.Text + "%";
                String num = num_disp.Text;
                num_disp.Text = Enum;
                fnum = double.Parse(num);
                opration = "%";
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (String.Compare(num_disp.Text, "") == 0)
            { }
            else
            {
                if (opration == "*")
                {
                    opration = "×";
                }
                int div = num_disp.Text.IndexOf(opration);
                String num = num_disp.Text.Substring(div + 1);
                //snum = Convert.ToDouble(nums);

                snum = Convert.ToDouble(Convert.ToString(num));

                if (String.Compare(opration, "+") == 0)
                {
                    result = fnum + snum;
                }
                else if (String.Compare(opration, "-") == 0)
                {
                    result = fnum - snum;
                }
                else if (String.Compare(opration, "×") == 0)
                {
                    result = fnum * snum;
                }
                else if (String.Compare(opration, "/") == 0)
                {
                    result = fnum / snum;
                }
                else if (String.Compare(opration, "%") == 0)
                {
                    result = fnum % snum;
                }
            
            calc_screen.Text = Convert.ToString(result);
        }
        }



    }
}
