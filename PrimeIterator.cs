using System.Collections.Generic;

namespace WhatIsThisNamespace
{
    public class PrimeIterator
    {
        private int _upperBound = 0;
        private int _currentNumber = 0;
        private List<int> _primeList = new List<int>();

        public PrimeIterator(int _upperBound)
        {
            this._upperBound = _upperBound;

            GeneratePrimes();
        }

        public int GetNextPrime()
        {
            if (_currentNumber == _primeList.Count) { return -1; }
            return _primeList[_currentNumber++];
        }

        private void GeneratePrimes()
        {
            for (int i = 2; i < _upperBound; i++)
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