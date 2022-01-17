using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    class Program
    {
        static List<Human> aliveHumans = new List<Human>();
        static List<Human> humansToKill = new List<Human>();
        static List<Human> deadHumans = new List<Human>();
        public static int currentYear = 1;
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to TrahsPanda's NEW AND IMPROVED Human Simulation!\n\nPlease enter the amount of Humans you would like to start with:");
            int humansAtStart = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease enter how many years you would like the Simulation to run:");
            int yearGoal = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < humansAtStart; i++)
            {
                aliveHumans.Add(new Human());
            }

            while (currentYear <= yearGoal)
            {
                SimulateYear();
                currentYear++;
            }
        }
        public static void SimulateYear()
        {
            Console.WriteLine("\nYEAR " + currentYear);
            foreach (Human human in aliveHumans)
            {
                // REPRODUCTION

                // Aging will be the last thing the simulation does to humans
                if (human.age >= 100)
                {
                    humansToKill.Add(human);
                }
                human.age++;
            }

            // Safetly moves all humans that will die into a deadHumans list - FINAL STEP
            foreach (Human human in humansToKill)
            {
                aliveHumans.Remove(human);
                deadHumans.Add(human);
            }
            humansToKill.Clear();
        }
    }
}
