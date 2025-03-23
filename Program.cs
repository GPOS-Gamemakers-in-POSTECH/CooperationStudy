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
            
            Calculator.calculator.SetPrimeGeneratorMaxNum(100);
            while (true)
            {
                int i = Calculator.calculator.primeGenerator.GetNextPrime();
                if (i == -1) { break; }
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine((int)Calculator.calculator.basicOperation.EvalStringToDouble("10*102-23+423/34"));
            Console.WriteLine(Calculator.calculator.basicOperation.Add(5, 10));
            Console.WriteLine(Calculator.calculator.basicOperation.Sub(10, 5));
            Console.WriteLine(Calculator.calculator.basicOperation.Div(5, 5));
            Console.WriteLine(Calculator.calculator.basicOperation.Mul(5, 5));

            Console.WriteLine(Calculator.calculator.euclideanOperation.GCD(12,18));
            Console.WriteLine(Calculator.calculator.euclideanOperation.LCM(12,18));
        }
    }
}
