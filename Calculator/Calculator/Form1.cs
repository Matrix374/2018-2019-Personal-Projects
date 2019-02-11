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

        string[] numbers = new string[2];
        string @operator;

        void UpdateCalculatorText() => numBox.Text = $"{numbers[0]} {@operator} {numbers[1]}";

        void AddNumber(string value)
        {
            int index = @operator == null ? 0 : 1;

            //Checks Number String for Decimal Points
            if (value == "." && numbers[index].Contains("."))
                return;

            //Concats Value to String Array
            numbers[index] += value;

            UpdateCalculatorText();
        }

        private void AddOperator(string value)
        {
            if (numbers[1] != null)
            {
                Calculate(value);
                return;
            }

            @operator = value;

            UpdateCalculatorText();
        }

        private void Calculate(string newOperator = null)
        {
            double? result = null;
            double? first = numbers[0] == null ? null : (double?)double.Parse(numbers[0]);
            double? second = numbers[0] == null ? null : (double?)double.Parse(numbers[1]);

            switch (@operator)
            {
                case "÷":
                    result = first / second;
                    break;
                case "×":
                    result = first * second;
                    break;
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
            }

            if (result != null)
            {
                numbers[0] = result.ToString();
                @operator = newOperator;
                numbers[1] = null;
                UpdateCalculatorText();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            numbers[0] = numbers[1] = null;
            @operator = null;
            UpdateCalculatorText();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            AddNumber("0");
        }

        private void num1_Click(object sender, EventArgs e)
        {
            AddNumber("1");
        }

        private void num2_Click(object sender, EventArgs e)
        {
            AddNumber("2");
        }

        private void num3_Click(object sender, EventArgs e)
        {
            AddNumber("3");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            AddNumber("4");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            AddNumber("5");
        }

        private void num6_Click(object sender, EventArgs e)
        {
            AddNumber("6");
        }

        private void num7_Click(object sender, EventArgs e)
        {
            AddNumber("7");
        }

        private void num8_Click(object sender, EventArgs e)
        {
            AddNumber("8");
        }

        private void num9_Click(object sender, EventArgs e)
        {
            AddNumber("9");
        }

        private void decButton_Click(object sender, EventArgs e)
        {
            AddNumber(".");
        }
    }
}
