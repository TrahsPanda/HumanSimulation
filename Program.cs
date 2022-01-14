using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulation;

namespace Simulation
{
    public static class Program
    {
        public static int yearInput;
        public static long humanStat;

        public static void Main(string[] args)
        {
            Pregnancy pregnancy = new Pregnancy();

            Console.WriteLine("Hello and welcome to TrahsPanda's Simulation!\nPlease enter the amount of Humans you want to start with:");
            long humanStat = Int64.Parse(Console.ReadLine());
            Console.WriteLine("How many years would you like the simulation to run?");
            int yearInput = Int32.Parse(Console.ReadLine());

            while (pregnancy.year <= yearInput)
            // Prints current year's stats
            Console.WriteLine("\nYEAR " + pregnancy.year);
            Console.Write("POPULATION: ");
            Console.WriteLine(humanStat.ToString("N0"));
            Console.Write("BIRTHS: ");
            Console.WriteLine(pregnancy.pregnancyStat.ToString("N0"));
            Console.Write("DEATHS: ");
            Console.WriteLine(pregnancy.babyDeathStat.ToString("N0"));
        }
    }
}
