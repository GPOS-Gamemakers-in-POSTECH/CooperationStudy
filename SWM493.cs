using System;

namespace WhatIsThisNamespace
{
    public class SWM493
    {
        public int FLAVITY(int num1, int B)
        {
            while (B != 0)
            {
                int C = B;
                B = num1 % B;
                num1 = C;
            }
            return num1;
        }

        public int FACTORY(int Z, int Y)
        {
            return (Z * Y) / FLAVITY(Z, Y);
        }
    }
}