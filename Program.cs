using System;

namespace DiceRollingSimulator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            // get the number of rolls from the user
            int rolls = Convert.ToInt32(Console.ReadLine());

            // Create instance of DiceSimulator and get the results
            DiceSimulator simulator = new DiceSimulator();
            //pass the number of rolls into the rolldice function we created in the other sheet
            int[] counts = simulator.RollDice(rolls);
            //this returns the counts of all the different numbers we rolled

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
                //we use double for the floats so we get plenty of decimals to round
                // pass in the i we created up top, (starting at one for offset) then we're gonna go up to 12 and 
                // increment by one, then for each, we pass in the one, divide by 100 to get the percentage
                double percentage = (double)counts[i] / rolls * 100;
                // turn the rounded value into an interger that we'lll use
                int asterisks = (int)Math.Round(percentage);

                // Print the necessary number of asterisks with proper formatting. 
                
                Console.Write($"{i,2}: ");
                //this fun little function prints an asterisk for the value of asterisks currently,
                // which we then loop through to print the asterisks
                Console.WriteLine(new string('*', asterisks));
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}

