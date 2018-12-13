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

                Console.WriteLine("How many people will be joining you?");

                int userInput2 = int.Parse(Console.ReadLine());
                    //userInput2 = Console.ReadLine().ToLower();
                    

                if (userInput2 == 0)
                {
                    Console.WriteLine("Don't forget to bring your sneakers!");
                }
                if (userInput2 >= 1 && userInput2 <= 4)
                {
                    Console.WriteLine("Make sure you get a sedan to fit everyone in!");
                }
                if (userInput2 >= 5 && userInput2 <= 10)
                {
                    Console.WriteLine("Make sure you get a Volkswagen bus to be able to fit everyone in!");
                }
                if (userInput2 >= 11)
                {
                    Console.WriteLine("Make sure you have an airplane to fit everyone in!");
                }
                else if (userInput2 < 0)
                {
                    Console.WriteLine("Invalid reply, please try again.");
                }
                Console.ReadLine();
            }



            // how many people are joining them
            //respond with a suggestion for both an activity and a recommendation on how they should travel
        }
    }
}
