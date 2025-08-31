using System;
using System.Linq.Expressions;

namespace CALCULATOREVISED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }
        public string ExpressionString = "";
        public string XString = "";
        public string YString = "";
        public char Operator = ' ';
        public int OpIndex;
        public void Input(char input)
        {
            if (label1.Text.Length < 13)
            {
                ExpressionString += input;
                label1.Text = ExpressionString;
            }
        }
        public void Calculate()
        {
            try
            {
                OpIndex = 0;

                for (int i = 1; i < ExpressionString.Length; i++)
                {
                    if (ExpressionString[i] == '+' || ExpressionString[i] == '/' || ExpressionString[i] == 'x' || ExpressionString[i] == '-')
                    {
                        OpIndex = i;
                        break;
                    }
                }

                XString = "";
                YString = "";
                Operator = ExpressionString[OpIndex];
                for (int i = 0; i < ExpressionString.Length; i++)
                {
                    if (i < OpIndex)
                    {
                        XString += ExpressionString[i];
                    }
                    if (i > OpIndex)
                    {
                        YString += ExpressionString[i];
                    }
                }
                double Result = 0;
                switch (Operator)
                {
                    case '+':
                        Result = Convert.ToDouble(XString) + Convert.ToDouble(YString);
                        break;
                    case '-':
                        Result = Convert.ToDouble(XString) - Convert.ToDouble(YString);
                        break;
                    case '/':
                        Result = Convert.ToDouble(XString) / Convert.ToDouble(YString);
                        break;
                    case 'x':
                        Result = Convert.ToDouble(XString) * Convert.ToDouble(YString);
                        break;
                }
                ExpressionString = Convert.ToString(Result);
            }
            catch (Exception e)
            {
            }
        }
        public void RoundDown()
        {
            string temp = "";
            for (int i = 0; i <= 5; i++)
            {
                temp += ExpressionString[i];
            }
            ExpressionString = temp;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Input('1');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Input('2');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Input('3');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Input('4');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Input('5');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Input('6');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Input('7');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Input('8');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Input('9');
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Input('0');
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Input('.');
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Input('/');
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Input('x');
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Input('-');
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Input('+');
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Calculate();
            if (ExpressionString.Length > 5) { RoundDown(); }
            label1.Text = ExpressionString;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string temp = "";
            for (int i = 0; i < ExpressionString.Length - 1; i++)
            {
                temp += ExpressionString[i];
            }
            ExpressionString = temp;
            label1.Text = ExpressionString;
        }
        
    }
}
