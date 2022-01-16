using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    class Program
    {
        public static int currentYear = 1;
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to TrahsPanda's NEW AND IMPROVED Human Simulation!\n\nPlease enter the amount of Humans you would like to start with:");
            int humansAtStart = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease enter how many years you would like the Simulation to run:");
            int yearGoal = Int32.Parse(Console.ReadLine());
            List<Human> aliveHumans = new List<Human>();
            for (int i = 0; i < humansAtStart; i++)
            {
                aliveHumans.Add(new Human());
            }

            while (currentYear < yearGoal)
            {
                SimulateYear();
                currentYear++;
            }
        }
        public static void SimulateYear()
        {
            foreach (Human human in aliveHumans) //CS0103 - No idea how to fix as aliveHumans is a List
            {
                Console.WriteLine(human.name);
                Console.WriteLine(human.age);
                human.age++;
            }
        }
    }
}
