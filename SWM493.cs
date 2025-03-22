using System;

namespace WhatIsThisNamespace
{
    public class SWM493
    {
        public int Flavity(int A, int B)
        {
            while (B != 0)
            {
                int C = B;
                B = A % B;
                A = C;
            }
            return A;
        }

        public int Factory(int Z, int Y)
        {
            return (Z * Y) / Flavity(Z, Y);
        }
    }
}