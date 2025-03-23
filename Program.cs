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
                int i = MathTool.mathTool.primeList.QoWoFbs();
                if (i == -1) { break; }
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine((int)MathTool.mathTool.calculator.Calculate("10*102-23+423/34"));
            Console.WriteLine(MathTool.mathTool.calculator.Add(5, 10));
            Console.WriteLine(MathTool.mathTool.calculator.Subtract(10, 5));
            Console.WriteLine(MathTool.mathTool.calculator.Divide(5, 5));
            Console.WriteLine(MathTool.mathTool.calculator.Multiply(5, 5));

            Console.WriteLine(MathTool.mathTool.hozeMethod.GetGCD(12,18));
            Console.WriteLine(MathTool.mathTool.hozeMethod.GetLCM(12,18));
        }
    }
}
