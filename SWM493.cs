using System;

namespace WhatIsThisNamespace
{
    public class Numbers
    {
        public int GCD(int Number1, int Number2)
        {
            while (Number2 != 0)
            {
                int tmp = Number2;
                Number2 = Number1 % Number2;
                Number1 = tmp;
            }
            return Number1;
        }

        public int LCM(int Number1, int Number2)
        {
            return (Number1 * Number2) / GCD(Number1, Number2);
        }
    }
}