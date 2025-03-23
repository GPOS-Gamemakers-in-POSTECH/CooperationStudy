using System;

namespace WhatIsThisNamespace
{
    public class SWM493
    {
        public int Flavity(int Number1, int Number2)
        {
            while (Number2 != 0)
            {
                int tmp = Number2;
                Number2 = Number1 % Number2;
                Number1 = tmp;
            }
            return Number1;
        }

        public int Factory(int Number1, int Number2)
        {
            return (Number1 * Number2) / Flavity(Number1, Number2);
        }
    }
}