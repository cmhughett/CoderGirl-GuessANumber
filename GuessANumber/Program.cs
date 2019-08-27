using System;

namespace GuessANumber
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number between 1 and 10: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            //int number = int.Parse(Console.ReadLine());

            // If they enter 8, output “You Win!”. Otherwise, output “You Lose.”. Do this using an inline if statement.

            if (number == 8)
            {
                Console.WriteLine("You Win!");
            }

            else if (number != 8)
            {
                Console.WriteLine("You Lose.");
            }

            Console.ReadLine();
        }
    }
}
