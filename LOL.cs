using System.Collections.Generic;

namespace WhatIsThisNamespace
{
    public class PrimeGenerator
    {
        private int _maxNum = 0;
        private int _count = 0;
        private List<int> _primeList = new List<int>();

        public PrimeGenerator(int MaxNum)
        {
            this._maxNum = MaxNum;

            InitializePrimeList();
        }

        public int GetNextPrime()
        {
            if (_count == _primeList.Count) { return -1; }
            return _primeList[_count++];
        }

        private void InitializePrimeList()
        {
            for (int i = 2; i < _maxNum; i++)
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
                    _primeList.Add(i);
                }
            }
        }
    }
}