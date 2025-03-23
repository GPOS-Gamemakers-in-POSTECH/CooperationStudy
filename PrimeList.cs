﻿using System.Collections.Generic;

namespace WhatIsThisNamespace
{
    public class PrimeList
    {
        private int _limitNumber = 0;
        private int _index = 0;
        private List<int> PrimeNumber = new List<int>();

        public Main(int LimitNumber)
        {
            this.LimitNumber = LimitNumber;

            FindPrime();
        }

        public int NextNode()
        {
            if (Index == PrimeNumber.Count) { return -1; }
            return PrimeNumber[Index++];
        }

        private void FindPrime()
        {
            for (int i = 2; i < LimitNumber; i++)
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
                    PrimeNumber.Add(i);
                }
            }
        }
    }
}
