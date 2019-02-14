using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalcEngine
    {

        string[] numbers;
        string @operator;
        string calcText;

        public CalcEngine()
        {
            numbers = new string[2];
            @operator = null;
            calcText = null;
        }

        public string[] Numbers { get => numbers; set => numbers = value; }
        public string Operator { get => @operator; set => @operator = value; }
        public string CalcText { get => calcText; set => calcText = value; }

        public void AddNumber(string value, ref string calcText)
        {
            int index = Operator == null ? 0 : 1;

            //Checks Number String for Decimal Points
            if (value == "." && Numbers[index].Contains("."))
                return;

            //Concats Value to String Array
            Numbers[index] += value;

            calcText = $"{Numbers[0]} {Operator} {Numbers[1]}";
        }

        public void Calculate(string newOperator, ref string calcText)
        {
            double? result = null;
            double? first = Numbers[0] == null ? null : (double?)double.Parse(Numbers[0]);
            double? second = Numbers[0] == null ? null : (double?)double.Parse(Numbers[1]);

            switch (Operator)
            {
                case "/":
                    result = first / second;
                    break;
                case "*":
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
                Numbers[0] = result.ToString();
                Operator = newOperator;
                Numbers[1] = null;

                calcText = $"{Numbers[0]} {Operator} {Numbers[1]}";
            }
        }
    }
}
