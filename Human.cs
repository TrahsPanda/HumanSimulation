using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{

    class Human
    {
        internal static Random random = new Random();
        // Basic ID system for Humans; Thanks Evelyn
        internal static ulong nextID = 1;
        public ulong ID = nextID++;

        public int age;
        public string name;
        internal static int genderCount = Enum.GetValues(typeof(Genders)).Length;
        public Genders gender = (Genders)random.Next(genderCount);
        public enum Genders
        {
            Male = 0,
            Female = 1,
            //NonBinary = 2,
            //GenderFluid = 3,
            //CowGender = 8,
        }
        // What every Human is
        public Human()
        {
            name = "Human " + ID;
            age = 1;
            Genders gender; // Warning can be safely ignored; Still functions properly
        }

    }

}
