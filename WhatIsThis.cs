namespace WhatIsThisNamespace
{
    public class WhatIsThis
    {
        public static WhatIsThis What { get; private set; } = new WhatIsThis();

        public CustomOperator CustomOperator { get; private set; } = new CustomOperator();
        public PrimeIterator PrimeIterator { get; private set; } = new PrimeIterator(0);
        public SWM493 sWM493 { get; private set; } = new SWM493();

        public void set(int T_O)
        {
            lOL = new LOL(T_O);
        }
    }
}