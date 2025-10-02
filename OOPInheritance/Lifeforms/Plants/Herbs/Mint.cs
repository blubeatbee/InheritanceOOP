using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance.Lifeforms.Plants.Herbs
{
    internal class Mint : Plant
    {
        protected string Species { get; set; } = "Lavender";
        protected string Family { get; set; } = "Mint";
        protected string Smell { get; set; } = "fresh and clear";
        public Mint (string toNomen, string toSpecies, string toFamily, int toAnnual, int toAge, string toOrigin, double toLength, string toSmell) : base(toNomen, toAnnual, toAge, toOrigin, toLength)
        {
            if (!string.IsNullOrWhiteSpace(toSpecies))
            {
                Species = toSpecies;
            }
            if (!string.IsNullOrWhiteSpace(toFamily)) {
                Family = toFamily;
            }

        }

        public void GetStats()
        {
            switch (Annual) {
                case "Annual":
                    Console.WriteLine($"This {Length} cm tall {Species} is {Age} years old and belongs to the {Family} family, native to {Origin}." +
                        $"\nThe {Species} has an annual lifecycle, meaning it lives and dies in under 1 year.");
                    break;
                case "Biennial":
                    Console.WriteLine($"This {Length} cm tall {Species} is {Age} years old and belongs to the {Family} family, native to {Origin}." +
                        $"\nThe {Species} has an biennial lifecycle, meaning it lives for 2 years.");
                    break;
                case "Perennial":
                    Console.WriteLine($"This {Length} cm tall {Species} is {Age} years old and belongs to the {Family} family, native to {Origin}." +
                        $"\nThe {Species} has an perennial lifecycle, meaning it lives for more than 3 years.");
                    break;
            }
        }

        public override void GetSmell()
        {
            Console.WriteLine($"This {Species} of the {Family} family smells {Smell}!");
        }

    }
}
