using System;

namespace AnonymusMethods1
{
    public delegate void MyDelegate();
    public delegate void MyIntDelegate(int x);
    public delegate void MyFirstDelegate();
    public delegate void Greet(string str);


    class Program
    {
        static Greet greet = delegate (string str)
        {
            Console.WriteLine("shalom " + str);
        };
        static MyDelegate mydelegate =
            delegate ()
            {
                Console.WriteLine("LO Chashuv !!!");
            };

        static MyIntDelegate myIntDelegate = delegate (int x)
        {
            Console.WriteLine("Anonymus prints" + x);
        };

        static MyFirstDelegate myFirstDelegate = delegate
        {
            Console.WriteLine("shalom ");
        };
        static MyFirstDelegate myFirstDelegate1 = delegate
        {
            Console.WriteLine("Antheur Shalom");
        };

        static void Main(string[] args)
        {
            greet("ariel");
            myFirstDelegate1();
            myFirstDelegate();
            mydelegate();
            myIntDelegate(44);
            Console.WriteLine("Hello World");
        }
    }
}
