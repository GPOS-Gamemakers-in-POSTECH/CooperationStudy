using System;
using WhatIsThisNamespace;

namespace CooperationStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕 세상!");
            
            WhatIsThis.What.set(100);
            while (true)
            {
                int i = WhatIsThis.What.PrimeIterator.GetNextPrime();
                if (i == -1) { break; }
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine((int)WhatIsThis.What.CustomOperator.ComputeByString("10*102-23+423/34"));
            Console.WriteLine(WhatIsThis.What.CustomOperator.Plus(5, 10));
            Console.WriteLine(WhatIsThis.What.CustomOperator.Minus(10, 5));
            Console.WriteLine(WhatIsThis.What.CustomOperator.Divide(5, 5));
            Console.WriteLine(WhatIsThis.What.CustomOperator.Multiply(5, 5));

            Console.WriteLine(WhatIsThis.What.GcdAndLcm.Gcd(12,18));
            Console.WriteLine(WhatIsThis.What.GcdAndLcm.Lcm(12,18));
        }
    }
}
