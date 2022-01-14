using System;
using Simulation;

namespace Simulation
{
    public class Pregnancy
    {
        public int year;
        public int pregnancyStat;
        public int babyDeathStat;
        public int twinStat;
        public int currentlyPregnant;
        public Pregnancy()
        {
            Random random = new Random();
            int year = 1;
            int pregnancyStat = 0;
            int babyDeathStat = 0;
            int twinStat = 0;
            int currentlyPregnant = 0;

            while (year <= Program.yearInput)
            {

                // REPRODUCTION
                if (Program.humanStat > 1)
                {
                    // humanCouple represnts every human coming together as a couple
                    long humanCouple = Program.humanStat / 2;
                    for (int x = 0; x < humanCouple; x++)
                    {
                        // This if statement checks if all criteria is met to breed
                        if (random.NextDouble() > 0.5)
                        {
                            // Twins and solo pregnancies
                            if (random.NextDouble() < 0.004)
                            {
                                currentlyPregnant += currentlyPregnant + 2;
                                pregnancyStat++;
                                twinStat++;
                            }
                            else
                            {
                                currentlyPregnant++;
                                pregnancyStat++;
                            }

                            // Runs through every pregnancy
                            for (int y = 0; y < currentlyPregnant; y++)
                            {
                                // Chance to kill a child
                                if (random.NextDouble() < 0.45)
                                {
                                    babyDeathStat++;
                                    currentlyPregnant--;
                                }
                            }
                            Program.humanStat += currentlyPregnant;
                            currentlyPregnant = 0;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Whatever you entered was not correct.");
                    Environment.Exit(0);
                }
                year++;
            }
        }

    }
}