using System;

namespace Number_Guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get app info
            GetAppInfo();

            //Greet user
            Greeting();

            while (true)
            {

                // Correct number
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init guess
                int guess = 0;

                // Ask user for guess
                Console.WriteLine("Guess a number between 1 and 10:");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // user guess
                    string newGuess = Console.ReadLine();

                    // Check input type
                    if (!int.TryParse(newGuess, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Not a number! Please try again:");
                        
                        continue;
                    }

                    // Cast input to int
                    guess = Int32.Parse(newGuess);

                    // Match guess
                    if (guess != correctNumber)
                    {

                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please guess again:");
                    }
                }
                // Success!
                PrintColorMessage(ConsoleColor.Yellow, "You guessed the right number!");

                // Play again
                Console.Write("Play again? (y/n):");

                // user input
                string playAgain = Console.ReadLine().ToUpper();

                if(playAgain == "Y")
                {
                    continue;
                } else if(playAgain == "N")
                {
                    return;
                } else
                {
                    return;
                }
            }
        }

        // Print App Info
        static void GetAppInfo()
        {
            // variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Nick Pugliesi";

            // app info
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            
            // reset text color
            Console.ResetColor();
        }

        // Print Greeting
        static void Greeting()
        {
            // Ask user for name
            Console.WriteLine("What is your name?");

            // Get user input
            string username = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", username);
        }

        // Print colored message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Test color
            Console.ForegroundColor = color;
            
            // Message
            Console.WriteLine(message);

            // reset text color
            Console.ResetColor();
        }
    }
}
