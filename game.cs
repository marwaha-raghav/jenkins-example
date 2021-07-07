using System;

namespace test_project
{
    public class game
    {
        static void main(string[] args)
        {
            //blank
        }

        public void GameLogic()
        {
            string choice;
            int maxNo = 100;
            int minNo = 1;
            int count = 0;
            Console.WriteLine($"Think of a number between {minNo} and {maxNo}");
            Console.WriteLine("Waiting to guess .... ");

            while(minNo <= maxNo)
            {   count++;
                int middle = (minNo + maxNo)/2;
                Console.WriteLine($"Is your number {middle}");
                Console.WriteLine("Enter yes/no");
                choice  = Console.ReadLine();
                if(String.Equals(choice, "yes"))
                {
                    Console.WriteLine("Your number is " + middle + " it took me " + count + " tries to find your number " );
                    Console.WriteLine(" Thanks for Playing!!!");
                    break;
                }

                else if(String.Equals(choice, "no"))
                {
                    Console.WriteLine(" Is your number less than " + middle);
                    Console.WriteLine("Enter yes/no");
                    var ch = Console.ReadLine();
                    if(String.Equals(ch, "yes"))
                    {
                        maxNo = middle -1;
                    }

                    else if(String.Equals(ch, "no"))
                    {
                        minNo = middle +1;
                    }

                    else
                    {
                        Console.WriteLine("Enter correct choice");
                    }

                }

            
                else
                {
                    Console.WriteLine("Enter a valid Option and try again");
                

                }
 
            }  
        
            
            



        }





    }





}