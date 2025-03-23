namespace WhatIsThisNamespace
{
    public class All
    {
        public static All all { get; private set; } = new All();

        public Calculator calculator { get; private set; } = new Calculator();
        public PrimeList primeList { get; private set; } = new PrimeList(0);
        public HozeMethod hozeMethod { get; private set; } = new HozeMethod();

        public void SetPrimeList(int LimitNumber)
        {
            primeList = new PrimeList(LimitNumber);
        }
    }
}
