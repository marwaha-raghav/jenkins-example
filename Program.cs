using System;
using Starter;

namespace test_project
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World to all of you!");
            Console.WriteLine("This is a C# Program");
            Console.WriteLine("Enjoy!");
            //Console.WriteLine("Hello World!");
            Console.WriteLine("This is a friendly C# Program");
            Console.WriteLine("Continue");
            Starter.Program ob = new Starter.Program();
            game gObject = new game();
            ob.func();
            gObject.GameLogic();
        }
    }
}
