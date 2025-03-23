namespace WhatIsThisNamespace
{
    public class WhatIsThis
    {
        public static WhatIsThis What { get; private set; } = new WhatIsThis();

        public CustomOperator CustomOperator { get; private set; } = new CustomOperator();
        public LOL lOL { get; private set; } = new LOL(0);
        public GcdAndLcm GcdAndLcm { get; private set; } = new GcdAndLcm();

        public void set(int T_O)
        {
            lOL = new LOL(T_O);
        }
    }
}