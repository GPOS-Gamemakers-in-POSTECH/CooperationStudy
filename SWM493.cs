using System;

namespace MiddleSchoolMathNamespace
{
    public class GCDAndLCM
    {
        public int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int c = b;
                b = a % b;
                a = c;
            }
            return a;
        }

        public int CalculateLCM(int z, int y)
        {
            return (z * y) / CalculateGCD(z, y);
        }
    }
}