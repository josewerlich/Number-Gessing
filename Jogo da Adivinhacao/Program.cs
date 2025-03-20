namespace Jogo_da_Adivinhacao
{
    internal class Program
    {
        // Version 2: Generate a random number
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

            Console.WriteLine("You typed the number: " + guessedNumber);
            Console.WriteLine("The secret number is: " + secretNumber);

            Console.ReadLine();
        }
    }
}
