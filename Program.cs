using System;
using WhatIsThisNamespace;

// Don't Fix This Code
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
                int i = WhatIsThis.What.primeGenerator.GetNextPrime();
                if (i == -1) { break; }
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine((int)WhatIsThis.What.utils.StringToDouble("10*102-23+423/34"));
            Console.WriteLine(WhatIsThis.What.utils.Plus(5, 10));
            Console.WriteLine(WhatIsThis.What.utils.Minus(10, 5));
            Console.WriteLine(WhatIsThis.What.utils.Divide(5, 5));
            Console.WriteLine(WhatIsThis.What.utils.Times(5, 5));

            Console.WriteLine(WhatIsThis.What.numbers.GCD(12,18));
            Console.WriteLine(WhatIsThis.What.numbers.LCM(12,18));
        }
    }
}
