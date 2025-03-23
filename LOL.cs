﻿using System.Collections.Generic;

namespace MiddleSchoolMathNamespace
{
    public class PrimeRelatedClass
    {
        private int _maxSizeOfIteration = 0;
        private int _indexOfList = 0;
        private List<int> _primeList = new List<int>();

        public PrimeRelatedClass(int _maxSizeOfIteration)
        {
            this._maxSizeOfIteration = _maxSizeOfIteration;

            AddPrimesToLIst();
        }

        public int GetPrimesFromList()
        {
            if (_indexOfList == _primeList.Count) { return -1; }
            return _primeList[_indexOfList++];
        }

        private void AddPrimesToLIst()
        {
            for (int i = 2; i < _maxSizeOfIteration; i++)
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