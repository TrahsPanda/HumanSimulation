using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    class SimulateYear
    {
        static public void Main(String[] args)
        {
            Human[] aliveHumans = new Human[5];
            for (int i = 0; i < 5; i++)
            {
                aliveHumans[i] = new Human();
            }
            foreach (Human human in aliveHumans)
            {
                Console.WriteLine(human.Name);
            }

        }
    }
}
