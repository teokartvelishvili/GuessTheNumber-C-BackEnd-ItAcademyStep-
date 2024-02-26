namespace GameGuessTheNumber_C_BackEnd_ItAcademyStep_
{

      

class Program
{
    static void Main(string[] args)
    {
        // Generate a random number between 1 and 10
        Random random = new Random();
        int randomNumber = random.Next(1, 10);
        
        int attempts = 0;
        bool guessedCorrectly = false;

        Console.WriteLine("Welcome to the Number Guessing Game! :) ");
        Console.WriteLine("I've picked a number between 1 and 10. Can you guess it?");

        // Loop until the user guesses the correct number
        while (!guessedCorrectly)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            
            int guess;
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Invalid input");
                continue;
            }

            attempts++;

            if (guess == randomNumber)
            {
                guessedCorrectly = true;
                Console.WriteLine($"Congratulations! You've guessed the correct number {randomNumber} in {attempts} attempts.");
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("The number is higher. Try again.");
            }
            else
            {
                Console.WriteLine("The number is lower. Try again.");
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}

    }
