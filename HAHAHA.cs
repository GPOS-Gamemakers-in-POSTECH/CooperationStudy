using System.Data;
using System;

namespace MiddleSchoolMathNamespace
{
    public class FourBasicOperations
    {
        public double ConvertStringToDouble(string target)
        {

            DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(target, ""));
        }

        public int Additive(int a, int b)
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
        public int Multipy(int a, int b)
        {
            return a * b;
        }
    }
}