using System;
using MiddleSchoolMathNamespace;

// Don't Fix This Code
namespace CooperationStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕 세상!");
            
            MiddleSchoolMath.MiddleSchoolManager.set(100);
            while (true)
            {
                int i = MiddleSchoolMath.MiddleSchoolManager.PrimeRelatedInstance.GetPrimesFromList();
                if (i == -1) { break; }
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine((int)MiddleSchoolMath.MiddleSchoolManager.FourBasicOperation.ConvertStringToDouble("10*102-23+423/34"));
            Console.WriteLine(MiddleSchoolMath.MiddleSchoolManager.FourBasicOperation.Add(5, 10));
            Console.WriteLine(MiddleSchoolMath.MiddleSchoolManager.FourBasicOperation.Subtract(10, 5));
            Console.WriteLine(MiddleSchoolMath.MiddleSchoolManager.FourBasicOperation.Divide(5, 5));
            Console.WriteLine(MiddleSchoolMath.MiddleSchoolManager.FourBasicOperation.Multipy(5, 5));

            Console.WriteLine(MiddleSchoolMath.MiddleSchoolManager.GCDAndLCMInstance.CalculateGCD(12,18));
            Console.WriteLine(MiddleSchoolMath.MiddleSchoolManager.GCDAndLCMInstance.CalculateLCM(12,18));
        }
    }
}
