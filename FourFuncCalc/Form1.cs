using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourFuncCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            numOne = numOne + double.Parse(textBox1.Text);
            textBox1.Clear();

            plusButtonClick = true;
            minusButtonClick = false;
            divideButtonClick = false;
            multiplyButtonClick = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(plusButtonClick == true)
            {
                numTwo = numOne + double.Parse(textBox1.Text);
            }
            else if(minusButtonClick == true)
            {
                numTwo = numOne - double.Parse(textBox1.Text);
            }
            else if(divideButtonClick == true)
            {
                numTwo = numOne / double.Parse(textBox1.Text);
            }
            else if(multiplyButtonClick == true)
            {
                numTwo = numOne * double.Parse(textBox1.Text);
            }

            textBox1.Text = numTwo.ToString();
            numOne = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            numOne = numOne + double.Parse(textBox1.Text);
            textBox1.Clear();

            plusButtonClick = false;
            minusButtonClick = true;
            divideButtonClick = false;
            multiplyButtonClick = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numOne = numOne + double.Parse(textBox1.Text);
            textBox1.Clear();

            plusButtonClick = false;
            minusButtonClick = false;
            divideButtonClick = false;
            multiplyButtonClick = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            numOne = numOne + double.Parse(textBox1.Text);
            textBox1.Clear();

            plusButtonClick = false;
            minusButtonClick = false;
            divideButtonClick = true;
            multiplyButtonClick = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(".");
        }
    }
}
