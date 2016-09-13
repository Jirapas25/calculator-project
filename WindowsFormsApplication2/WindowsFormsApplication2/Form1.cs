using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public string operators;
        public bool cal = false;
        public string temp;
        public int first=0, last=0,sum=0,flag=0;

        public Form1()
        {
            InitializeComponent();
        }
        public void Display(string var)
        {
            displaySumBox.Text += var;
            
        }
        public void DisplaySum()
        {
                switch (operators)
                {
                    case "+": sum = first + last; break;
                    case "-": sum = first - last; break;
                    case "*": sum = first * last; break;
                    case "/": sum = first / last; break;
                }
                displaySumBox.Text = sum.ToString();
                first = sum;
                last = 0;
                flag = 0;
                operators = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaySumBox.Text = "0";
        }

        private void butt0_Click(object sender, EventArgs e)
        {
            if (displaySumBox.Text == "0") {
                displaySumBox.Text = "";
            }
            if (string.IsNullOrEmpty(operators))
            {
                Display("0");
            }
            else
            {
                if (flag == 0)
                {
                    displaySumBox.Text = "";
                    flag = 1;
                }
                Display("0");
            }
        }

        private void butt1_Click(object sender, EventArgs e)
        {
            if (displaySumBox.Text == "0")
            {
                displaySumBox.Text = "";
            }
            if (string.IsNullOrEmpty(operators))
            {
                Display("1");
            }
            else
            {
                if (flag == 0)
                {
                    displaySumBox.Text = "";
                    flag = 1;
                }
                Display("1");
            }

        }

        private void butt2_Click(object sender, EventArgs e)
        {
            if (displaySumBox.Text == "0")
            {
                displaySumBox.Text = "";
            }
            if (string.IsNullOrEmpty(operators))
            {
                Display("2");
            }
            else
            {
                if (flag == 0)
                {
                    displaySumBox.Text = "";
                    flag = 1;
                }
                Display("2");
            }
        }

        private void butt3_Click(object sender, EventArgs e)
        {
            if (displaySumBox.Text == "0")
            {
                displaySumBox.Text = "";
            }
            if (string.IsNullOrEmpty(operators))
            {
                Display("3");
            }
            else
            {
                if (flag == 0)
                {
                    displaySumBox.Text = "";
                    flag = 1;
                }
                Display("3");
            }
        }

        private void butt4_Click(object sender, EventArgs e)
        {
            if (displaySumBox.Text == "0")
            {
                displaySumBox.Text = "";
            }
            if (string.IsNullOrEmpty(operators))
            {
                Display("4");
            }
            else
            {
                if (flag == 0)
                {
                    displaySumBox.Text = "";
                    flag = 1;
                }
                Display("4");
            }
        }

        private void butt5_Click(object sender, EventArgs e)
        {
            if (displaySumBox.Text == "0")
            {
                displaySumBox.Text = "";
            }
            if (string.IsNullOrEmpty(operators))
            {
                Display("5");
            }
            else
            {
                if (flag == 0)
                {
                    displaySumBox.Text = "";
                    flag = 1;
                }
                Display("5");
            }
        }

        private void butt6_Click(object sender, EventArgs e)
        {
            if (displaySumBox.Text == "0")
            {
                displaySumBox.Text = "";
            }
            if (string.IsNullOrEmpty(operators))
            {
                Display("6");
            }
            else
            {
                if (flag == 0)
                {
                    displaySumBox.Text = "";
                    flag = 1;
                }
                Display("6");
            }
        }

        private void butt7_Click(object sender, EventArgs e)
        {
            if (displaySumBox.Text == "0")
            {
                displaySumBox.Text = "";
            }
            if (string.IsNullOrEmpty(operators))
            {
                Display("7");
            }
            else
            {
                if (flag == 0)
                {
                    displaySumBox.Text = "";
                    flag = 1;
                }
                Display("7");
            }
        }

        private void butt8_Click(object sender, EventArgs e)
        {
            if (displaySumBox.Text == "0")
            {
                displaySumBox.Text = "";
            }
            if (string.IsNullOrEmpty(operators))
            {
                Display("8");
            }
            else
            {
                if (flag == 0)
                {
                    displaySumBox.Text = "";
                    flag = 1;
                }
                Display("8");
            }
        }

        private void butt9_Click(object sender, EventArgs e)
        {
            if (displaySumBox.Text == "0")
            {
                displaySumBox.Text = "";
            }
            if (string.IsNullOrEmpty(operators))
            {
                Display("9");
            }
            else
            {
                if (flag == 0)
                {
                    displaySumBox.Text = "";
                    flag = 1;
                }
                Display("9");
            }
        }

        private void buttDivide_Click(object sender, EventArgs e)
        {
            
            first = Int32.Parse(displaySumBox.Text);
            operators = "/";
        }

        private void buttMultiply_Click(object sender, EventArgs e)
        {
            first = Int32.Parse(displaySumBox.Text);
            operators = "*";
            
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            displaySumBox.Text = "0";
            operators = "";
            first = 0;
            last = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displaySumBox.Text = "0";
            if (operators == "")
            {
                first = 0;
            }
            else {
                last = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = displaySumBox.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }

            displaySumBox.Text = s;
        }

        private void buttSum_Click(object sender, EventArgs e)
        {
            last = Int32.Parse(displaySumBox.Text);
            DisplaySum();
            
        }

        private void buttPlus_Click(object sender, EventArgs e)
        {
            first = Int32.Parse(displaySumBox.Text);
            operators = "+";
        }

        private void buttMinus_Click(object sender, EventArgs e)
        {
            first = Int32.Parse(displaySumBox.Text);
            operators = "-";
        }
    }
}
