using System;

namespace Starter
{
    public class Program
    {
        public void func()
        {
        Console.WriteLine("Hello World, this is namespace starter");
        Console.WriteLine("What is your name?");
        Console.WriteLine("Test for rebase");
        var name = Console.ReadLine();
        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
        Console.Write($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey(true);

        }   

    }
}