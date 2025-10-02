using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance.Lifeforms.Animals.Reptiles
{
    internal class Chameleon : Animal
    {
        // Properties with default values
        protected string Family { get; set; } = "Chameleon";
        protected bool IsCamo { get; set; } = false;

        public Chameleon(string toNomen, string toFamily, string toName, int toSex, int toAge, string toOrigin, double toWeight, string toTameOrWild, bool toCamo) : base(toNomen, toName, toSex, toAge, toOrigin, toWeight, toTameOrWild)
        {
            if (!string.IsNullOrWhiteSpace(toFamily)) {
                Family = toFamily; // If the constructor takes in an empty string, this if statement ensures the default Property value will not be updated
            }
            IsCamo = toCamo;
        }

        public void IsCamoflauged()
        {
            if (IsCamo) {
                Console.WriteLine($"{Name} is camoflauged! Where did it go?");
            }
            else {
                Console.WriteLine($"{Name} is visible!");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} made a noise! \"Hiss!\"");
        }
    }
}
