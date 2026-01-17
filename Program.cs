using System;

namespace DiceRollingSimulator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            int rolls = Convert.ToInt32(Console.ReadLine());

            // Create instance of DiceSimulator and get the results
            DiceSimulator simulator = new DiceSimulator();
            int[] counts = simulator.RollDice(rolls);

            // Display the histogram
            Console.WriteLine();
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {rolls}.");
            Console.WriteLine();

            // Print histogram for each possible sum (2-12)
            for (int i = 2; i <= 12; i++)
            {
                // Calculate percentage and number of asterisks
                double percentage = (double)counts[i] / rolls * 100;
                int asterisks = (int)Math.Round(percentage);

                // Print the line with proper formatting
                Console.Write($"{i,2}: ");
                Console.WriteLine(new string('*', asterisks));
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
