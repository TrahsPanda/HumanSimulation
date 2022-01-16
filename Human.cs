using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{

    class Human
    {
        internal static ulong nextID = 1;
        public ulong ID = nextID++;

        internal static int nextAge = 0;
        public int age = nextAge++;

        public string name;


        public Human()
        {
            name = "Human " + ID;
            age = 0;
        }

    }

}
