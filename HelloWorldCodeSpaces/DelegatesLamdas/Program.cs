using System;



namespace DelegatesLamdas
{
    class CheckingDelegates
    {
        public static void Main(string[] args)
        {
            
            Calculations.MathOp MathOperation = Calculations.sub;

            //We can also send the instance as delegate or function
            //Console.WriteLine(Calculations.CalculatePrint(5,6,MathOperation));

            Console.WriteLine(Calculations.CalculatePrint(5,6,Calculations.sub));


            //using lamdas
            Console.WriteLine(Calculations.CalculatePrint(5,5,(x,y)=> x+y)); 
            Console.WriteLine(Calculations.CalculatePrint(5,5,(x,y)=> x*y)); 
        }

    }

    

}
