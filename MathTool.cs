namespace WhatIsThisNamespace
{
    public class MathTool
    {
        public static MathTool mathTool { get; private set; } = new MathTool();

        public Calculator Calculator2 { get; private set; } = new Calculator();
        public PrimeList PrimeList2 { get; private set; } = new PrimeList(0);
        public HozeMethod HozeMethod2 { get; private set; } = new HozeMethod();

        public void SetPrimeList(int LimitNumber)
        {
            PrimeList2 = new PrimeList(LimitNumber);
        }
    }
}
