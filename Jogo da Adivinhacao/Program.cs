namespace Jogo_da_Adivinhacao
{
    internal class Program
    {
        // Version 1: User data entry and basic structure
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Guess the Number");
            Console.WriteLine("---------------------------------");

            // guessing logic

;          

            Console.Write("Type a number from 1 to 20: ");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You typed the number: " + guessedNumber);
            

            Console.ReadLine();
        }
    }
}
