using System;


namespace DelegatesLamdas
{
    class CheckingDelegates
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello WOrld");
            MathOp MathOperation = sub;

            CalculatePrint(5,6,MathOperation) ;
        }

        static void CalculatePrint(int x, int y, MathOp f)
        {
            Console.WriteLine(f(x,y));
        }



        public static int add(int a, int b)
        {
            return a+b;
        }

        public static int sub(int a, int b)
        {
            return a-b;
        }

        delegate int MathOp(int x, int y);
    }

    

}
