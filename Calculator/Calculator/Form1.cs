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

        void UpdateCalculatorText() => numBox.Text = calcText;

        private void deleteButton_Click(object sender, EventArgs e)
        {
            calcText = null;
            UpdateCalculatorText();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            calc.Calculate();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            calc.AddNumber("0", ref calcText);
            UpdateCalculatorText();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            calc.AddNumber("1", ref calcText);
            UpdateCalculatorText();
        }

        private void num2_Click(object sender, EventArgs e)
        {
           calc. AddNumber("2", ref calcText);
           UpdateCalculatorText();
        }

        private void num3_Click(object sender, EventArgs e)
        {
            calc.AddNumber("3", ref calcText);
            UpdateCalculatorText();
        }

        private void num4_Click(object sender, EventArgs e)
        {
            calc.AddNumber("4", ref calcText);
            UpdateCalculatorText();
        }

        private void num5_Click(object sender, EventArgs e)
        {
            calc.AddNumber("5", ref calcText);
            UpdateCalculatorText();
        }

        private void num6_Click(object sender, EventArgs e)
        {
            calc.AddNumber("6", ref calcText);
            UpdateCalculatorText();
        }

        private void num7_Click(object sender, EventArgs e)
        {
            calc.AddNumber("7", ref calcText);
            UpdateCalculatorText();
        }

        private void num8_Click(object sender, EventArgs e)
        {
            calc.AddNumber("8", ref calcText);
            UpdateCalculatorText();
        }

        private void num9_Click(object sender, EventArgs e)
        {
            calc.AddNumber("9", ref calcText);
            UpdateCalculatorText();
        }

        private void decButton_Click(object sender, EventArgs e)
        {
            calc.AddNumber(".", ref calcText);
            UpdateCalculatorText();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            if (numbers[1] != null)
            {
                calc.Calculate("/", ref calcText);
                return;
            }

            @operator = "/";

            UpdateCalculatorText();
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            if (numbers[1] != null)
            {
                calc.Calculate("*", ref calcText);
                return;
            }

            @operator = "*";

            UpdateCalculatorText();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (numbers[1] != null)
            {
                calc.Calculate("+", ref calcText);
                return;
            }

            @operator = "+";

            UpdateCalculatorText();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (numbers[1] != null)
            {
                calc.Calculate("-", ref calcText);
                return;
            }

            @operator = "-";

            UpdateCalculatorText();
        }
    }
}
