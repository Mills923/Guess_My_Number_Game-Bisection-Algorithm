using System;

namespace Guess_My_Number_Game_Bisection_Algorithm_
{
    class Program
    {
        public static void BisectionMethod()
        {
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("Choose a number between 1 and 10: ");
            string response = Console.ReadLine();
            int value = Int32.Parse(response);
            if (value < 0 || value > 10)
            {
                Console.WriteLine("You chose an invalid number. Game over.");
                Environment.Exit(0);
            }
            bool isEqual = false;

            int length = list.Length-1;
            int start = list[0];
            int end = list[length];

            int count = 0;


            while (isEqual == false)
            {
                int middle = (start + end) / 2;

                if (value > middle)
                {
                    
                   //start = list[middle];
                    //end = list[length];
                    Console.WriteLine($"Value is higher than {middle}. Running again");
                    start = middle +1;
                    count++;
                }
                else if (value < middle)
                {
                    //start = list[0];
                    //end = list[middle];
                    Console.WriteLine($"Value is lower than {middle}. Running again.");
                    //middle = (start + end) / 2;
                    end = middle - 1;
                    count++;
                }
                else if (value == middle)
                {
                    isEqual = true;
                    Console.WriteLine($"Your guess was {middle}! It only took me {count} attempts!");
                }
            }


            //bisection_search(value, list);



        }

        public static void HumanGuess()
        {
            Random r = new Random();
            int myGuess = r.Next(1, 1001);
            bool isEqual = false;
            Console.WriteLine("I have chosen a number between 1 and 1000! Try to guess!");
            int humanGuess = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (isEqual == false)
            {
                if (humanGuess > myGuess)
                {
                    isEqual = false;
                    Console.WriteLine("Your guess is too high! Guess again!");
                    humanGuess = Convert.ToInt32(Console.ReadLine());
                    count++;
                }
                else if (humanGuess < myGuess)
                {
                    isEqual = false;
                    Console.WriteLine("Your guess is too low! Guess again!");
                    humanGuess = Convert.ToInt32(Console.ReadLine());
                    count++;
                }
                else if (humanGuess == myGuess)
                {
                    isEqual = true;
                    Console.WriteLine($"Good job you guessed correct! It took {count} iterations!");
                }
            }


            Console.WriteLine($"My number was: {myGuess}");

        }

        public static void ComputerGuess()
        {
            Console.WriteLine("Choose a number between 1 and 1000");
            int humanValue = Convert.ToInt32(Console.ReadLine());
            bool isEqual = false;
            int count = 0;
            Random r = new Random();
            int holder = 1001;
            int first = 1;

            while (isEqual == false)
            {
               
                int computerGuess = r.Next(first, holder);
                Console.WriteLine($"I am guessing {computerGuess}. Am I right? \n If my guess was too high please type 1. \n If my guess was too low please type 2. \n If I am right please type 3.");
                int hint = Convert.ToInt32(Console.ReadLine());
                if (hint == 1)
                {
                    holder = computerGuess;
                    count++;
                    
                }
                else if (hint == 2)
                {
                    first = computerGuess;
                    count++;
                }
                else if (hint ==3)
                {
                    isEqual = true;
                    Console.WriteLine($"Your number was {humanValue} and I guessed {computerGuess}! It only took {count} iterations!" );
                }
                else
                {
                    Console.WriteLine("You are not following the rules. Game over");
                }
            }

        }


        static void Main(string[] args)
        {
            //HumanGuess();
            //BisectionMethod();
            //ComputerGuess();
        }
    }
}
