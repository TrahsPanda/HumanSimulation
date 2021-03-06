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
        public static bool hasPartner = false;
        internal static int genderCount = Enum.GetValues(typeof(Genders)).Length;
        public Genders gender = (Genders)random.Next(genderCount);
        public enum Genders
        {
            Male = 0,
            Female = 1,
        }
        // What every Human is
        public Human()
        {
            name = "Human" + ID;
            age = 1;
            hasPartner = false;
        }

    }

}
