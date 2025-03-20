namespace Jogo_da_Adivinhacao
{
    internal class Program
    {
        // Version 3: Validate if player guessed the correct number
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Guess the Number");
            Console.WriteLine("---------------------------------");

            // guessing logic

            Random numberGenerator = new Random();

            int secretNumber = numberGenerator.Next(1, 21);

            Console.Write("Type a number from 1 to 20: ");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());

            if(guessedNumber == secretNumber)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Congratulations, you guessed the secret number");
                Console.WriteLine("---------------------------------");

            }
            else if (guessedNumber > secretNumber)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("The guessed number is higher than the secret number");
                Console.WriteLine("---------------------------------");

            }

            else
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("The guessed number is lower than the secret number");
                Console.WriteLine("---------------------------------");
            }
                Console.WriteLine("You typed the number: " + guessedNumber);
                Console.WriteLine("The secret number is: " + secretNumber);

            Console.ReadLine();
        }
    }
}
