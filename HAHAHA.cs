using System.Data;
using System;

namespace WhatIsThisNamespace
{
    public class Utils
    {
        public double StringToDouble(string s)
        {

            DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(s, ""));
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
        public int Times(int a, int b)
        {
            return a * b;
        }
    }
}