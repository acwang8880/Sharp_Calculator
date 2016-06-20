using System;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        ArrayList workingMemory = new ArrayList<String>();
        String input;
        char operation;
        String operand1 = string.Empty;
        String operand2 = string.Empty;
        double solution = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void decim_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                solution = num1 + num2;
                this.textBox1.Text = solution.ToString();
            }
            else if (operation == '-')
            {
                solution = num1 - num2;
                this.textBox1.Text = solution.ToString();
            }
            else if (operation == '*')
            {
                solution = num1 * num2;
                this.textBox1.Text = solution.ToString();
            }
            else if (operation == '/')
            {
                if (num1 != 0)
                {
                    solution = num1 / num2;
                    this.textBox1.Text = solution.ToString();
                }
                else
                {
                    this.textBox1.Text = "Can't divide by zero";
                }
            }
            input = string.Empty;
        }


        private void clear_Click(object sender, EventArgs e)
        {
            operand1 = string.Empty;
            operand2 = string.Empty;
            input = string.Empty;
            this.textBox1.Text = "";
            operation = 'c';
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input = input.Substring(0, input.Length - 1);
            this.textBox1.Text = input;
        }
    }
}
