using System;

namespace Lab3DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string userName = Console.ReadLine();
            bool oddEven = true;
            while (oddEven)
            {
                // Input
                
                Console.WriteLine("Enter a number from 1 to 100 please");
                string userInput = Console.ReadLine();
                int number = int.Parse(userInput);

                //Processing & output
                if ((number % 2 != 0) && (number < 60) && (number > 0))
                {
                    Console.WriteLine($"{userName}, {number} is odd");
                }
                else if ((number % 2 == 0) && (number >= 2) && (number <= 25))
                {
                    Console.WriteLine($"{userName}, {number} is even and less than 25");
                }
                else if ((number % 2 == 0) && (number >= 26) && (number <= 60))
                {
                    Console.WriteLine($"{userName}, the result is even");
                }
                else if ((number % 2 == 0) && (number > 60) && (number <= 100))
                {
                    Console.WriteLine($"{userName}, {number} is even");
                }
                else if ((number % 2 != 0) && (number > 60) && (number <= 100))
                {
                    Console.WriteLine($"{userName}, {number} is odd");
                }
                else
                {
                    Console.WriteLine($"{userName}, I'm sorry that number is not between 1 to 100");
                }
                bool tryAgain = true;
                while (tryAgain)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{userName}, would you like to try again? y or n");
                    string userAnswer = Console.ReadLine().ToLower();
                    switch (userAnswer)
                    {
                        case "y":
                            tryAgain = false;
                            break;
                        case "n":
                            oddEven = false;
                            tryAgain = false;
                            break;
                        default:
                            Console.WriteLine($"{userName}, that could not be computed. Please type y for yes or n for no");
                            break;
                    }

                }
            }
            Console.WriteLine("Goodbye");



        }
    }

}