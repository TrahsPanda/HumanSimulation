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
        public static ulong ID = nextID++;

        public string Name = "Human " + nextID;
    }

}
