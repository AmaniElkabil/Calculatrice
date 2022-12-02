using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double resulat = 0.0;
        string input = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcul_Click(object sender, EventArgs e)
        {

        }

        private void num0_Click(object sender, EventArgs e)
        {
            Calcul.Text = "";
            input += "0";
            Calcul.Text += input;
        }

        private void virgule_Click(object sender, EventArgs e)
        {
            input += ".";
            Calcul.Text = input;
        }

        private void egal_Click(object sender, EventArgs e)
        {
            second = input;
            double firstnum, secondnum;
            firstnum = Convert.ToDouble(first);
            secondnum = Convert.ToDouble(second);
            //plus
            if (function == '+')
            {
                resulat = firstnum + secondnum;
                Calcul.Text = resulat.ToString();
            }
            //moins
            else if (function == '-') 
            {
                resulat = firstnum - secondnum;
                Calcul.Text = resulat.ToString();
            }
            //divise
            else if (function == '/')
            {
                if (secondnum == 0) 
                {
                    Calcul.Text = "!!!!Error!!!!";
                }
                else 
                {
                    resulat = firstnum / secondnum;
                    Calcul.Text = resulat.ToString();
                }
            }
            //multiple
            else if (function == '*')
            {
                resulat = firstnum * secondnum;
                Calcul.Text = resulat.ToString();
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            function = '+';
            first = input;
            input = "";
        }

        private void moins_Click(object sender, EventArgs e)
        {
            function = '-';
            first = input;
            input = "";
            label_result.Text = first + second;
        }

        private void multiple_Click(object sender, EventArgs e)
        {
            function = '*';
            first = input;
            input = "";
            label_result.Text = first + second;

        }

        private void divise_Click(object sender, EventArgs e)
        {
            function = '/';
            first = input;
            input = "";
            label_result.Text = first + second;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            input = "";
            resulat = 0.0;
            Calcul.Text = "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            Calcul.Text = "";
            input += "1";
            Calcul.Text += input;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            Calcul.Text = "";
            input += "2";
            Calcul.Text += input;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            Calcul.Text = "";
            input += "3";
            Calcul.Text += input;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            Calcul.Text = "";
            input += "4";
            Calcul.Text += input;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            Calcul.Text = "";
            input += "5";
            Calcul.Text += input;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            Calcul.Text = "";
            input += "6";
            Calcul.Text += input;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            Calcul.Text = "";
            input += "7";
            Calcul.Text += input;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            Calcul.Text = "";
            input += "8";
            Calcul.Text += input;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            Calcul.Text = "";
            input += "9";
            Calcul.Text += input;
        }

        private void labelresult_Click(object sender, EventArgs e)
        {
            label_result.Text = "";

        }
    }
}
