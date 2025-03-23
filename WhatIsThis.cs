namespace WhatIsThisNamespace
{
    public class WhatIsThis
    {
        public static WhatIsThis What { get; private set; } = new WhatIsThis();

        public HAHAHA hAHAHA { get; private set; } = new HAHAHA();
        public PrimeGenerator primeGenerator { get; private set; } = new PrimeGenerator(0);
        public SWM493 sWM493 { get; private set; } = new SWM493();

        public void set(int MaxNum)
        {
            primeGenerator = new PrimeGenerator(MaxNum);
        }
    }
}