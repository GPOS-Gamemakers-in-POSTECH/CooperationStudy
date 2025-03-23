using System.Data;
using System;

namespace WhatIsThisNamespace
{
    public class BasicOperation
    {
        public double EvalStringToDouble(string s)
        {
            DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(s, ""));
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
}