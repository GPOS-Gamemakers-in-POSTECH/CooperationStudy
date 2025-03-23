namespace WhatIsThisNamespace
{
    public class WhatIsThis
    {
        public static WhatIsThis What { get; private set; } = new WhatIsThis();

        public Utils utils { get; private set; } = new Utils();
        public PrimeGenerator primeGenerator { get; private set; } = new PrimeGenerator(0);
        public Numbers numbers { get; private set; } = new Numbers();

        public void set(int MaxNum)
        {
            primeGenerator = new PrimeGenerator(MaxNum);
        }
    }
}