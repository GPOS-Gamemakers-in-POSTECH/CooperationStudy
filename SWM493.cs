using System;

namespace MiddleSchoolMathNamespace
{
    public class GCDAndLCM
    {
        public int CalculateGCD(int A, int B)
        {
            while (B != 0)
            {
                int C = B;
                B = A % B;
                A = C;
            }
            return A;
        }

        public int CalculateLCM(int Z, int Y)
        {
            return (Z * Y) / CalculateGCD(Z, Y);
        }
    }
}