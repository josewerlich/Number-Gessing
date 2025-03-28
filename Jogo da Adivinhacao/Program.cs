﻿using System.ComponentModel.Design;

namespace Jogo_da_Adivinhacao
{
    internal class Program
    {
        // Version 7: Update the logic for the player to lose if he does not guess the number 
        // Player will start with 100 points
        static void Main(string[] args)
        {

            string[] guessedNumberHistorical = new string[100];
            int historicalCount = 0;

            

            while (true)

            {
                Console.Clear();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Guess the Number");
                Console.WriteLine("---------------------------------");

                //levels

                Console.WriteLine("Levels");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1 - Easy (10 guesses)");
                Console.WriteLine("2 - Medium (5 guesses)");
                Console.WriteLine("3 - Hard (3 guesses)");
                Console.WriteLine("---------------------------------");

                int totalGuesses = 0;

                Console.WriteLine("Select a level: ");
                string level = Console.ReadLine();

                if (level == "1")
                    totalGuesses = 10;

                else if (level == "2")
                    totalGuesses = 5;

                else
                    totalGuesses = 3;

                // random number

                Random numberGenerator = new Random();

                int secretNumber = numberGenerator.Next(1, 21);

                int playerScore = 100;

                // game logic

                Console.Clear() ;

                for (int guessing = 1; guessing <= totalGuesses; guessing++)
                {
                    for (int counter = 0; counter < historicalCount; counter++)
                    {
                        Console.WriteLine("Hitorical number: " + $" {guessedNumberHistorical[counter]}");
                    }


                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"Guessing {guessing} of {totalGuesses}");
                    Console.WriteLine("---------------------------------");
                    Console.Write("Type a number from 1 to 20: ");
                    int guessedNumber = Convert.ToInt32(Console.ReadLine());

                    guessedNumberHistorical[historicalCount] = $"{guessedNumber}";

                    if (guessing != totalGuesses)
                    {


                        if (guessedNumber == secretNumber)
                        {
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("Congratulations, you guessed the secret number");
                            Console.WriteLine("---------------------------------");
                            break;

                        }
                        else if (guessedNumber > secretNumber)
                        {

                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("The secret number is lower");
                            Console.WriteLine("---------------------------------");
                            playerScore = playerScore - (guessedNumber - secretNumber);

                        }

                        else
                        {

                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("The secret number is higher");
                            Console.WriteLine("---------------------------------");
                            playerScore = playerScore - (secretNumber - guessedNumber);


                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("You lost! Good luck next time...");
                        playerScore = 0;
                    }

                    historicalCount++;
                }
                 
                Console.WriteLine("Score: " + playerScore);
                
                Console.WriteLine("Do you want to try again? Press Y/N ");
                string toContinue = Console.ReadLine().ToUpper();

                historicalCount = 0;

                if (toContinue != "Y")
                    break;
            }
        }
        
    }
}
