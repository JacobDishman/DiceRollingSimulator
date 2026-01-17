using System;

namespace DiceRollingSimulator
{
    public class DiceSimulator
    {
        private Random rnd = new Random();

        public int[] RollDice(int numberOfRolls)
        {
            // This array needs to store counts for sums 2-12 since you can't roll a 1 with 2 dice. 
            // we use 13 since we 0 and 1 is impossible, and we don't wanna have to offest everything.
            int[] counts = new int[13];

            for (int i = 0; i < numberOfRolls; i++)
            {
                int dice1 = rnd.Next(1, 7); // Roll first die (1-6)
                int dice2 = rnd.Next(1, 7); // Roll second die (1-6)
                int sum = dice1 + dice2;
                counts[sum]++;
            }

            return counts;
        }
    }
}

