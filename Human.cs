using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{

    class Human
    {
        public Random random = new Random(); // I'm gonna move this somewhere later
        // Basic ID system for Humans; Thanks Evelyn
        internal static ulong nextID = 1;
        public ulong ID = nextID++;

        public int age;
        public string name;
        string _gender;
        public string gender;
        public void Gender()
        {
            if (random.NextDouble() > 0.5)
            {
                _gender = "Female";

            }
            else
            {
                _gender = "Male";
            }

        }


        // What every Human is
        public Human()
        {
            name = "Human " + ID;
            age = 1;
            gender = _gender;
        }

    }

}
