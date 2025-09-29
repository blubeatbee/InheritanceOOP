using OOPInheritance.Lifeforms.Animals.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance.Lifeforms.Animals.Mammals.Ursa
{
    internal class PolarBear : Bear
    {
        protected string Species { get; set; } = "Polar Bear"; // Set default value with "Polar Bear" that will be overriden with the constructor
        protected bool Endangered { get; set; } = true; 

        public PolarBear(string toNomen, string toSpecies, string toFamily, string toName, int toSex, int toAge, string toOrigin, double toWeight, string toTameOrWild, bool toDanger) : base(toNomen, toFamily, toName, toSex, toAge, toOrigin, toWeight, toTameOrWild)
        {
            if (!string.IsNullOrWhiteSpace(toSpecies)) {
                Species = toSpecies; // If the constructor takes in an empty string, this if statement ensures the default Property value will not be updated
            }
            Endangered = toDanger;
        }

        public void IsVulnerable()
        {
            if (Endangered)
            {
                Console.WriteLine($"{Species}s are vulnerable of becoming endangered :(");
            }
            else if (!Endangered)
            {
                Console.WriteLine($"{Species}s are no longer threatened of being endangered :)");
            }
            else
            {
                Console.WriteLine($"No conservation status data for {Species}s");
            }
        }

        public void GetStats()
        {
            Console.WriteLine($"{Name} is a {Age} year old {Sex} {Species} of the {Family} family native to {Origin}, weighing at {Weight} kg.");
        }

    }
}
