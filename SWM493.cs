using System;

namespace WhatIsThisNamespace
{
    public class SWM493
    {
        public int DoEuclideanAlgorithm(int num1, int num2)
        {
            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2; //if num1 < num2, replacing일 것이다.
                num1 = temp;
            }
            return num1;
        }

        public int GetLeastCommonMultiple(int num1, int num2)
        {
            return (num1 * num2) / DoEuclideanAlgorithm(num1, num2);
        }
    }
}