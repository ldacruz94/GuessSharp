using System;

namespace guess_sharp
{
    class GuessSharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting up the number guessing game...");
            
            Random random = new Random();
            int maxValue = 10;
            int generatedNum = random.Next(maxValue);

            bool proceed = true;
            int totalTries = 5;
            while (proceed)
            {
                if (totalTries == 0) {
                    Console.WriteLine("You have no more tries left. Game over! Sorry!");
                    break;
                }

                Console.WriteLine("Enter a number between 1-10:");
                string guess = Console.ReadLine();

                if (Int32.Parse(guess) == generatedNum)
                {
                    Console.WriteLine("You guessed correctly!");
                    break;
                }
                else
                {
                    Console.WriteLine("Guessed wrong, try again!");
                    totalTries -= 1;
                }
            }
        }
    }
}
