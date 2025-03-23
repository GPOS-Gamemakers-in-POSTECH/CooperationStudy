using System;
using MathToolbox;

// Don't Fix This Code
namespace BasicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕 세상!");
            
            MathManger.s_mathManger.SetPrimeLimit(100);
            while (true)
            {
                int Prime = MathManger.s_mathManger.PrimeNumbers.GetNextPrime();
                if (Prime == -1) { break; }
                Console.Write(Prime + " ");
            }

            Console.WriteLine();
            Console.WriteLine((int)MathManger.s_mathManger.CalculationTool.EvaluateExpression("10*102-23+423/34"));
            Console.WriteLine(MathManger.s_mathManger.CalculationTool.Add(5, 10));
            Console.WriteLine(MathManger.s_mathManger.CalculationTool.Sub(10, 5));
            Console.WriteLine(MathManger.s_mathManger.CalculationTool.Divide(5, 5));
            Console.WriteLine(MathManger.s_mathManger.CalculationTool.Multiply(5, 5));

            Console.WriteLine(MathManger.s_mathManger.GcdLcmTool.Gcd(12,18));
            Console.WriteLine(MathManger.s_mathManger.GcdLcmTool.Lcm(12,18));
        }
    }
}
