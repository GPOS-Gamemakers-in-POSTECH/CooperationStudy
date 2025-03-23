namespace WhatIsThisNamespace
{
    public class WhatIsThis
    {
        public static WhatIsThis What { get; private set; } = new WhatIsThis();

        public CustomOperator CustomOperator { get; private set; } = new CustomOperator();
        public GcdAndLcm GcdAndLcm { get; private set; } = new GcdAndLcm();
        public PrimeIterator PrimeIterator { get; private set; } = new PrimeIterator(0);

        public void set(int T_O)
        {
            lOL = new LOL(T_O);
        }
    }
}