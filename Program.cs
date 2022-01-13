using System;

namespace Simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to TrahsPanda's Simulation!\nPlease enter the amount of Humans you want to start with:");
            long humanStat = Int64.Parse(Console.ReadLine());
            int pregnancyStat = 0;
            int pregnancy = 0;
            int babyDeathStat = 0;
            int year = 1;
            Random random = new Random();

            while (year <= 100)
            {
                year++;
                if (humanStat > 1)
                {
                    Console.WriteLine("\nYEAR " + year);
                    Console.Write("POPULATION: ");
                    Console.WriteLine(humanStat.ToString("N0"));
                    Console.Write("BIRHTS: ");
                    Console.WriteLine(pregnancyStat.ToString("N0"));
                    Console.Write("DEATHS: ");
                    Console.WriteLine(babyDeathStat.ToString("N0"));
                    // humanDivided represnts every human coming together as a couple
                    long humanCouple = humanStat / 2;
                for (int x = 0; x < humanCouple; x++)
                {
                    // This if statement acts as a random bool to represent the couples deciding if they want to breed
                    if (random.NextDouble() > 0.5)
                        {
                            // Twins and solo pregnancies
                            if (random.NextDouble() < 0.004)
                            {
                                pregnancy += pregnancy + 2;
                                pregnancyStat++;
                            }
                            else
                            {
                                pregnancy++;
                                pregnancyStat++;
                            }

                            // Runs through every pregnancy
                            for (int y = 0; y < pregnancy; y++)
                            {
                                // Chance to kill a child
                                if (random.NextDouble() < 0.45)
                                {
                                    babyDeathStat++;
                                    pregnancy--;
                                }
                            }
                            humanStat += pregnancy;
                            pregnancy = 0;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Whatever you entered was not correct.");
                    break;
                }
            }
        }

    }
}