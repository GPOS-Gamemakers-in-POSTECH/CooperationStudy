using System.Collections.Generic;

namespace WhatIsThisNamespace
{
    public class LOL
    {
        private int T_O = 0;
        private int T_H_E = 0;
        private List<int> S_T_A_R = new List<int>();

        public LOL(int T_O)
        {
            this.T_O = T_O;

            WjsWoDud();
        }

        public int QoWoFbs()
        {
            if (T_H_E == S_T_A_R.Count) { return -1; }
            return S_T_A_R[T_H_E++];
        }

        private void WjsWoDud()
        {
            for (int i = 2; i < T_O; i++)
            {
                bool _T_ = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        _T_ = false;
                        break;
                    }
                }
                if (_T_)
                {
                    S_T_A_R.Add(i);
                }
            }
        }
    }
}