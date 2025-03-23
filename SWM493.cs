using System;

namespace MiddleSchoolMathNamespace
{
    public class GCDAndLCM
    {
        public int CalculateGCD(int num1, int num2)
        {
            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }

        public int CalculateLCM(int num1, int num2)
        {
            return (num1 * num2) / CalculateGCD(num1, num2);
        }
    }
}