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

                // Aging will be the last thing the simulation does
                if (human.age > 100)
                {
                    var humanToMove = human;
                    humansToKill.Add(humanToMove);
                }
                Console.WriteLine(human.age); //Testing
                human.age++;

                foreach (Human humanToKill in humansToKill)
                {
                    var humanToMove = human;
                    aliveHumans.Remove(humanToMove);
                    deadHumans.Add(humanToMove);
                }
            }
            humansToKill.Clear();
        }
    }
}
