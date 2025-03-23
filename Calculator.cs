using System.Data;
using System;

namespace BasicCalculator
{
    public class Calculator
    {
        public double EvaluateExpression(string expression)
        {

            DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(expression, ""));
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}