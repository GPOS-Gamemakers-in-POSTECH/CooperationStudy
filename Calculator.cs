namespace WhatIsThisNamespace
{
    public class Calculator
    {
        public static Calculator calculator { get; private set; } = new Calculator();

        public BasicOperation basicOperation { get; private set; } = new BasicOperation();
        public PrimeGenerator primeGenerator { get; private set; } = new PrimeGenerator(0);
        public EuclideanOperation euclideanOperation { get; private set; } = new EuclideanOperation();

        public void SetPrimeGeneratorMaxNum(int maxNum)
        {
            primeGenerator = new PrimeGenerator(maxNum);
        }
    }
}