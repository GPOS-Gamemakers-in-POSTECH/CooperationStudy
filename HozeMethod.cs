using System;

namespace WhatIsThisNamespace
{
    public class HozeMethod
    {
        public int GetGCD(int num2, int num1)
        {
            while (num1 != 0)
            {
                int temp = num1;
                num1 = num2 % num1;
                num2 = temp;
            }
            return num2;
        }

        public int GetLCM(int num1, int num2)
        {
            return (num1 * num2) / GetGCD(num1, num2);
        }
    }
}
