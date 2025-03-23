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

            MathTool.mathTool.SetPrimeList(100);
            while (true)
            {
                int i = MathTool.mathTool.primeList.NextNode();
                if (i == -1) { break; }
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine((int)MathTool.mathTool.Calculator2.Calculate("10*102-23+423/34"));
            Console.WriteLine(MathTool.mathTool.Calculator2.Add(5, 10));
            Console.WriteLine(MathTool.mathTool.Calculator2.Subtract(10, 5));
            Console.WriteLine(MathTool.mathTool.Calculator2.Divide(5, 5));
            Console.WriteLine(MathTool.mathTool.Calculator2.Multiply(5, 5));

            Console.WriteLine(MathTool.mathTool.HozeMethod2.GetGCD(12,18));
            Console.WriteLine(MathTool.mathTool.HozeMethod2.GetLCM(12,18));
        }
    }
}
