using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_13FunRecommendations
{
    class Program
    {
        static void Main(string[] args)
        {
            // You will ask the user what type of activity they are in the mood for
            Console.WriteLine("Hello!");
            Console.WriteLine("What type of activity are you in the mood for (pick one of the following: action, chilling, danger, good food)?");
            string userInput;
            userInput = Console.ReadLine().ToLower();

            

            while (true)
            {

                if (userInput != "action" && userInput != "chilling" && userInput != "danger" && userInput != "good food")
                {
                    Console.WriteLine("Not a valid choice, please try again.");
                }
                else
                {
                    if (userInput == "action")
                    {
                        Console.WriteLine("Go stock car racing!");
                        Console.WriteLine();
                    }
                    if (userInput == "chilling")
                    {
                        Console.WriteLine("Go hiking!");
                        Console.WriteLine();
                    }
                    if (userInput == "danger")
                    {
                        Console.WriteLine("Go skydiving!");
                        Console.WriteLine();
                    }
                    if (userInput == "good food")
                    {
                        Console.WriteLine("Go to Taco Bell!");
                        Console.WriteLine();
                    }
                }

                Console.WriteLine("A: 0");
                Console.WriteLine("B: 1 to 4");
                Console.WriteLine("C: 5 to 10");
                Console.WriteLine("D: More than 11");
                Console.WriteLine("How many people will be joining you? (please pick from choices, i.e. A)");

                string userInput2 = Console.ReadLine().ToUpper();
                //userInput2 = Console.ReadLine().ToLower();

                if (userInput2 == "A")
                {
                    Console.WriteLine("Don't forget to bring your sneakers!");
                    Console.WriteLine();
                    Console.WriteLine("Goodbye and have fun!");
                    Console.ReadLine();
                }
                if (userInput2 == "B")
                {
                    Console.WriteLine("Make sure you get a sedan to fit everyone in!");
                    Console.WriteLine();
                    Console.WriteLine("Goodbye and have fun!");
                    Console.ReadLine();
                }
                if (userInput2 == "C")
                {
                    Console.WriteLine("Make sure you get a Volkswagen bus to be able to fit everyone in!");
                    Console.WriteLine();
                    Console.WriteLine("Goodbye and have fun!");
                    Console.ReadLine();
                }
                if (userInput2 == "D")
                {
                    Console.WriteLine("Make sure you have an airplane to fit everyone in!");
                    Console.WriteLine();
                    Console.WriteLine("Goodbye and have fun!");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Invalid reply, please try again.");
                    Console.ReadLine();
                }
                
            }



            // how many people are joining them
            //respond with a suggestion for both an activity and a recommendation on how they should travel
        }
    }
}
