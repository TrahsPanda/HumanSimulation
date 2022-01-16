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

        public int age = 0;

        public string name;


        public Human()
        {
            name = "Human " + ID;
            age = 0;
        }

    }

}
