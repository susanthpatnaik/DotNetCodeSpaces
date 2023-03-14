using System;

namespace Generics
{

    class genericsClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DataStore<string>.printMethod("Hello"));
            nonGenericClass.print<string>("Hello");
        }
    }

    public class DataStore<generic>
    {
        public generic Data{get;set;}

        public static generic printMethod(generic data)
        {
            return data;
        }
    }

    //Class is not generic but method is a generic method

    public class nonGenericClass
    {
        public static void print<T>(T data )
        {
            Console.WriteLine(data);

        }
    }
}