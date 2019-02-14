using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalcEngine
    {

        private string[] numbers;
        private string @operator;

        public CalcEngine()
        {
            Operator = null;
            Numbers = new string[2];
        }

        public string[] Numbers { get => numbers; set => numbers = value; }
        public string Operator { get => @operator; set => @operator = value; }

        public string Update()
        {
            return $"{Numbers[0]} {Operator} {Numbers[1]}";
        }

        public void AddNumber(string value)
        {
            int index = Operator == null ? 0 : 1;

            //Checks Number String for Decimal Points
            if (value == "." && numbers[index].Contains("."))
                return;

            //Concats Value to String Array
            Numbers[index] += value;

            Update();
        }

        public void Calculate(string newOperator = null)
        {
            double? result = null;
            double? first = Numbers[0] == null ? null : (double?)double.Parse(numbers[0]);
            double? second = Numbers[0] == null ? null : (double?)double.Parse(numbers[1]);

            switch (@operator)
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
                Update();
            }
        }

        public void Delete()
        {
            Numbers[0] = Numbers[1] = null;
            Operator = null;
            Update();
        }
    }
}
