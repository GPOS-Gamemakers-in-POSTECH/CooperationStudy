using System.Data;
using System;

namespace WhatIsThisNamespace
{
    public class HAHAHA
    {
        public double AToZ(string asdf)
        {

            DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(asdf, ""));
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