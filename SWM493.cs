using System;

namespace WhatIsThisNamespace
{
    public class SWM493
    {
        public int FLAVITY(int num1, int num2)
        {
            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }

        public int FACTORY(int num1, int num2)
        {
            return (num1 * num2) / FLAVITY(num1, num2);
        }
    }
}