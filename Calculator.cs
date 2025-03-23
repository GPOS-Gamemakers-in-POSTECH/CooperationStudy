using System.Data;
using System;

namespace WhatIsThisNamespace
{
    public class Calculator
    {
        public double Calculate(string str)
        {

            DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(str, ""));
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
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
