using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance.Lifeforms.Animals.Mammals
{
    internal class Human : Animal
    {
        // Properties with default values
        protected string Family { get; set; } = "Homo";
        protected string HairC { get; set; } = "Brown";

        protected Human(string toNomen, string toFamily, string toName, int toSex, int toAge, string toOrigin, double toWeight, string toTameOrWild, string toHairC) : base(toNomen, toName, toSex, toAge, toOrigin, toWeight, toTameOrWild)
        {
            if (!string.IsNullOrWhiteSpace(toFamily)) {
                Family = toFamily; // If the constructor takes in an empty string, this if statement ensures the default Property value will not be updated
            }
            if (!string.IsNullOrWhiteSpace(toHairC)) {
                HairC = toHairC; // Same here
            }
        }

        public void GetHairColour()
        {
            Console.WriteLine($"{Name} has {HairC} hair.");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} made a noise! \"Mamma mia!\"");
        }
    }
}
