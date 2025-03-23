using System;

namespace WhatIsThisNamespace
{
    public class EuclideanOperation
    {
        public int GCD(int num1, int num2)
        {
            while (num2 != 0)
            {
                int tmp = num2;
                num2 = num1 % num2;
                num1 = tmp;
            }
            return num1;
        }

        public int LCM(int num1, int num2)
        {
            return (num1 * num2) / GCD(num1, num2);
        }
    }
}