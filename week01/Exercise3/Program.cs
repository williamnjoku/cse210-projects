using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes"; 
        
        while (playAgain.ToLower() == "yes")
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(1,101);

            int guessNumber = 0;
            int attempts = 0;

            while (guessNumber != number)
            {
                Console.Write("Guess the magic number: ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);

                attempts++;

                if (guessNumber > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < number)
                {
                    Console.WriteLine("Higher");
                }

            }
            
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {attempts} attempts.");

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine("Thank you for playing.");
    }
}