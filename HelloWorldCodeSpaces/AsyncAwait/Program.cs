using System;


namespace asyncawait
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello World");
            Task.Run(longFunction);
            shortFunction();
        }


        public static void longFunction()
        {            
            
            Console.WriteLine("Long function started");
            Thread.Sleep(5000);
            Console.WriteLine("Long function completed");      
        }

        public static void shortFunction()
        {
            Console.WriteLine("Short function started");
            Thread.Sleep(1000);
            Console.WriteLine("Short function completed");
        }
    }
}