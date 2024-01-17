using System;

class Program
{
    static void Main(string[] args)
    {
        // Greeting
        Console.WriteLine("\nHello Prep3 World!");

        // Randome Number Generator
        Random randomGenerator = new();

        //Variable
        string keepPlaying;


        // User Guessing Game
        do//Keeps Playing
        {
            // Game Variables
            int magicNumber = randomGenerator.Next(1, 101);// Randum Number Generator and parameters
            string result;// Feedback to user
            int gameCounter = 0;// Total games played by user
            int userNumber;

            do//One Game
            {
                // Asking for Input
                Console.Write("\nWhat is the magic number? ");
                string userInput = Console.ReadLine();// stores user's number as string

                userNumber = int.Parse(userInput);// converts user's string to integer


                // Evaluates the User's Guess
                if (userNumber > magicNumber)// user's guess is too high
                {
                    result = "Lower";
                }
                else if (userNumber < magicNumber)// user's guess is too low
                {
                    result = "Higher";
                }
                else
                {
                    result = "You guessed it!";// user's guess is just right
                }


                // Adds one per round
                gameCounter++;


                // Show Results
                Console.WriteLine(result);

            } while (userNumber != magicNumber);


            // Prints Game Counter
            Console.WriteLine($"You guessed {gameCounter} times\n");


            // Asks to continue
            Console.Write("Do you want to play again? ");
            keepPlaying = Console.ReadLine();//user input

        } while (keepPlaying == "yes");//continues until they stop saying yes
    }
}