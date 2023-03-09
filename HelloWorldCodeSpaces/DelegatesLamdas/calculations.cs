using System;


namespace DelegatesLamdas
{
    class Calculations
    {
       
        public static int CalculatePrint(int x, int y, MathOp f)
        {
            return (f(x,y));
        }


        public static int add(int a, int b)
        {
            return a+b;
        }

        public static int sub(int a, int b)
        {
            return a-b;
        }

        public delegate int MathOp(int x, int y);
    }

    

}
