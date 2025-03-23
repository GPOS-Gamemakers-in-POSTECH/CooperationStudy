namespace BasicCalculator
{
    public class MathManager
    {
        public static MathManager s_mathManager { get; private set; } = new MathManager();

        public Calculator CalculationTool { get; private set; } = new Calculator();
        public PrimeGenerator PrimeNumbers { get; private set; } = new PrimeGenerator(0);
        public GcdLcmCalculator gcdLcmCalculator { get; private set; } = new GcdLcmCalculator();

        public void SetPrimeLimit(int maxValue)
        {
            PrimeNumbers = new PrimeGenerator(maxValue);
        }
    }
}