namespace MiddleSchoolMathNamespace
{
    public class MiddleSchoolMath
    {
        public static MiddleSchoolMath MiddleSchoolManager { get; private set; } = new MiddleSchoolMath();

        public FourBasicOperations FourBasicOperation { get; private set; } = new FourBasicOperations();
        public PrimeRelatedClass PrimeRelatedInstance { get; private set; } = new PrimeRelatedClass(0);
        public GCDAndLCM GCDAndLCMInstance { get; private set; } = new GCDAndLCM();

        public void set(int _maxSizeOfIteration)
        {
            PrimeRelatedInstance = new PrimeRelatedClass(_maxSizeOfIteration);
        }
    }
}