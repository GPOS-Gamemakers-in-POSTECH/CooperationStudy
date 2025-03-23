using System.Data;
using System;

namespace WhatIsThisNamespace
{
    public class CustomOperator
    {
        public double ComputeByString(string asdf)
        {

            DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(asdf, ""));
        }

        public int Plus(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
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