using OOPInheritance.Lifeforms.Animals.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance.Lifeforms.Animals.Mammals.Ursa
{
    internal class BrownBear : Bear
    {
        protected string Species { get; set; } = "Brown Bear";

        public BrownBear(string toNomen, string toSpecies, string toFamily, string toName, int toSex, int toAge, string toOrigin, double toWeight, string toTameOrWild) : base( toNomen, toFamily, toName, toSex, toAge, toOrigin, toWeight, toTameOrWild)
        {
            if (!string.IsNullOrWhiteSpace(toSpecies)) {
                Species = toSpecies; // If the constructor takes in an empty string, this if statement ensures the default Property value will not be updated
            }
        }

        // Overrides the GetWeight() virtual method in the Animal parent class
        public override void GetWeight()
        {
            if (Age <= 1)
            {
                if (Weight <= 27)
                {
                    Console.WriteLine($"{Name} weighs around {Weight} kg, which is normal for a cub {Species}.");
                }
                else if (Weight > 27)
                {
                    Console.WriteLine($"{Name} weighs around {Weight} kg, which is more than average for a cub {Species}.");
                }
            }
            else if (Age > 1 && Age < 5)
            {
                if (Weight <= 80 && Weight > 27)
                {
                    Console.WriteLine($"{Name} weighs around {Weight} kg, which is normal for an adolescent {Species}.");
                }
                else if (Weight > 80)
                {
                    Console.WriteLine($"{Name} weighs around {Weight} kg, which is more than average for an adolescent {Species}.");
                }
                else if (Weight <= 27)
                {
                    Console.WriteLine($"{Name} weighs around {Weight} kg, which is underweight for an adolescent {Species}.");
                }
            }
            else if (Age >= 5 )
            {
                if (Weight <= 111 && Weight > 57)
                {
                    Console.WriteLine($"{Name} weighs around {Weight} kg, which is normal for an adult {Species}.");
                }
                else if (Weight > 112)
                {
                    Console.WriteLine($"{Name} weighs around {Weight} kg, which is overweight for an adult {Species}.");
                }
                else if (Weight <= 56)
                {
                    Console.WriteLine($"{Name} weighs around {Weight} kg, which is underweight for an adult {Species}.");
                }
            }
            else
            {
                Console.WriteLine($"No data to display. Did you set age and weight correctly?");
            }
        }

        public void GetStats()
        {
            Console.WriteLine($"{Name} is a {Age} year old {Sex} {Species} of the {Family} family native to {Origin}, weighing at {Weight} kg.");
        }
    }
}
