using System;

namespace BasicCalculator
{
    public class GcdLcmCalculator
    {
        public int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public int Lcm(int x, int y)
        {
            return (x * y) / Gcd(x, y);
        }
    }
}