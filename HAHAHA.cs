using System.Data;
using System;

namespace WhatIsThisNamespace
{
    public class HAHAHA
    {
        public double ConvertStringToDouble(string target)
        {

            DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(target, ""));
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int subtract(int a, int b)
        {
            return a - b;
        }
        public int divide(int a, int b)
        {
            return a / b;
        }
        public int multipy(int a, int b)
        {
            return a * b;
        }
    }
}