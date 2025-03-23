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

            All.all.set(100);
            while (true)
            {
                int i = All.all.primeList.QoWoFbs();
                if (i == -1) { break; }
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine((int)All.all.calculator.Calculate("10*102-23+423/34"));
            Console.WriteLine(All.all.calculator.Add(5, 10));
            Console.WriteLine(All.all.calculator.Subtract(10, 5));
            Console.WriteLine(All.all.calculator.Divide(5, 5));
            Console.WriteLine(All.all.calculator.Multiply(5, 5));

            Console.WriteLine(All.all.hozeMethod.GetGCD(12,18));
            Console.WriteLine(All.all.hozeMethod.GetLCM(12,18));
        }
    }
}
