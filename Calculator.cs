using System.Data;
using System;

namespace WhatIsThisNamespace
{
    public class Operator
    {
        public double Calculate(string str)
        {

            DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(str, ""));
        }

        public int A(int a, int b)
        {
            return a + b;
        }
        public int B(int a, int b)
        {
            return a - b;
        }
        public int C(int a, int b)
        {
            return a / b;
        }
        public int D(int a, int b)
        {
            return a * b;
        }
    }
}
