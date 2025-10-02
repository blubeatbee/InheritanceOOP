using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance.Lifeforms.Animals.Mammals
{
    internal class Bear : Animal
    {
        // Property with default value
        protected string Family { get; set; } = "Bear";

        protected Bear(string toNomen, string toFamily, string toName, int toSex, int toAge, string toOrigin, double toWeight, string toTameOrWild) : base(toNomen, toName, toSex, toAge, toOrigin, toWeight, toTameOrWild)
        {
            if (!string.IsNullOrWhiteSpace(toFamily)) {
                Family = toFamily; // If the constructor takes in an empty string, this if statement ensures the default Property value will not be updated
            }
        }

        public void IsHibernating()
        {
            DateTime now = DateTime.Now;
            if (now.Month >= 10 || now.Month <= 3) {
                Console.WriteLine($"{Name} is hibernating.");

            }
            else {
                Family = $"{Name} is not hibernating. Be careful!";
            }
        }

        public override void MakeSound()
        {
                Console.WriteLine($"{Name} made a noise! \"Roar!\"");
        }
    }
}