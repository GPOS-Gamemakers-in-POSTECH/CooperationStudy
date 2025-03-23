using System.Collections.Generic;

namespace BasicCalculator
{
    public class PrimeGenerator
    {
        private int _limit = 0;
        private int _index = 0;
        private List<int> _primes = new List<int>();

        public PrimeGenerator(int limit)
        {
            this._limit = limit;
            GeneratePrimes();
        }

        public int GetNextPrime()
        {
            if (_index == _primes.Count) { return -1; }
            return _primes[_index++];
        }

        private void GeneratePrimes()
        {
            for (int i = 2; i < _limit; i++)
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
                    _primes.Add(i);
                }
            }
        }
    }
}
