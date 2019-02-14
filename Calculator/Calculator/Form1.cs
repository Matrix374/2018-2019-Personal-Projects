using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CalcEngine calc = new CalcEngine();
        string calcText;

        void UpdateCalculatorText() => numBox.Text = calc.Update();

        private void deleteButton_Click(object sender, EventArgs e)
        {
            calc.Delete();
            UpdateCalculatorText();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            calc.Calculate();
            UpdateCalculatorText();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            calc.AddNumber("0");
            UpdateCalculatorText();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            calc.AddNumber("1");
            UpdateCalculatorText();
        }

        private void num2_Click(object sender, EventArgs e)
        {
           calc. AddNumber("2");
           UpdateCalculatorText();
        }

        private void num3_Click(object sender, EventArgs e)
        {
            calc.AddNumber("3");
            UpdateCalculatorText();
        }

        private void num4_Click(object sender, EventArgs e)
        {
            calc.AddNumber("4");
            UpdateCalculatorText();
        }

        private void num5_Click(object sender, EventArgs e)
        {
            calc.AddNumber("5");
            UpdateCalculatorText();
        }

        private void num6_Click(object sender, EventArgs e)
        {
            calc.AddNumber("6");
            UpdateCalculatorText();
        }

        private void num7_Click(object sender, EventArgs e)
        {
            calc.AddNumber("7");
            UpdateCalculatorText();
        }

        private void num8_Click(object sender, EventArgs e)
        {
            calc.AddNumber("8");
            UpdateCalculatorText();
        }

        private void num9_Click(object sender, EventArgs e)
        {
            calc.AddNumber("9");
            UpdateCalculatorText();
        }

        private void decButton_Click(object sender, EventArgs e)
        {
            calc.AddNumber(".");
            UpdateCalculatorText();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            if (calc.Numbers[1] != null)
            {
                calc.Calculate("/");
                return;
            }

            calc.Operator = "/";

            UpdateCalculatorText();
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            if (calc.Numbers[1] != null)
            {
                calc.Calculate("*");
                return;
            }

            calc.Operator = "*";

            UpdateCalculatorText();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (calc.Numbers[1] != null)
            {
                calc.Calculate("+");
                return;
            }

            calc.Operator = "+";

            UpdateCalculatorText();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (calc.Numbers[1] != null)
            {
                calc.Calculate("-");
                return;
            }

            calc.Operator = "-";

            UpdateCalculatorText();
        }
    }
}
