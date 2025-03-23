using System;

namespace WhatIsThisNamespace
{
    public class HozeMethod
    {
        public int GetGCD(int A, int B)
        {
            while (B != 0)
            {
                int C = B;
                B = A % B;
                A = C;
            }
            return A;
        }

        public int GetLCM(int Z, int Y)
        {
            return (Z * Y) / GetGCD(Z, Y);
        }
    }
}
