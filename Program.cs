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
            // test comment fot git hook
            //TEST COMMENT 2 FOR GIT
            //Test Comment 3got git revert
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
