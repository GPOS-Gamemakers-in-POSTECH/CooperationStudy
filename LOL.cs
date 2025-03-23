using System.Collections.Generic;

namespace WhatIsThisNamespace
{
    public class LOL
    {
        private int upperBound = 0;
        private int currentNumber = 0;
        private List<int> primeList = new List<int>();

        public LOL(int upperBound)
        {
            this.upperBound = upperBound;

            GeneratePrimes();
        }

        public int GetNextPrime()
        {
            if (currentNumber == primeList.Count) { return -1; }
            return primeList[currentNumber++];
        }

        private void GeneratePrimes()
        {
            for (int i = 2; i < upperBound; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeList.Add(i);
                }
            }
        }
    }
}