using System.Collections.Generic;

namespace WhatIsThisNamespace
{
    public class PrimeList
    {
        private int _limitNumber = 0;
        private int _index = 0;
        private List<int> _primenumber = new List<int>();

        public Main(int LimitNumber)
        {
            this.LimitNumber = LimitNumber;

            FindPrime();
        }

        public int NextNode()
        {
            if (Index == _primenumber.Count) { return -1; }
            return _primenumber[Index++];
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
                    _primenumber.Add(i);
                }
            }
        }
    }
}
