using System;

namespace DiceRollingSimulator
{
    public class DiceSimulator
    {
        private Random rnd = new Random();

        public int[] RollDice(int numberOfRolls)
        {
            // Array to store counts for sums 2-12
            // Index 0 and 1 are unused; indices 2-12 hold the counts
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
