namespace WhatIsThisNamespace
{
    public class MathTool
    {
        public static MathTool mathTool { get; private set; } = new MathTool();

        public Calculator calculator { get; private set; } = new Calculator();
        public PrimeList primeList { get; private set; } = new PrimeList(0);
        public HozeMethod hozeMethod { get; private set; } = new HozeMethod();

        public void SetPrimeList(int LimitNumber)
        {
            primeList = new PrimeList(LimitNumber);
        }
    }
}
