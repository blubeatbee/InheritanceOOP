using OOPInheritance.Lifeforms.Animals.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPInheritance.Lifeforms.Animals.Mammals.Homo
{
    internal class Sapiens : Human
    {
        protected string Species { get; set; } = "Human";

        protected string Nationality { get; set; } = "Swedish";

        public Sapiens(string toNomen, string toSpecies, string toFamily, string toName, int toSex, int toAge, string toOrigin, string toNation, double toWeight, string toTameOrWild, string toHairC) : base(toNomen, toFamily, toName, toSex, toAge, toOrigin, toWeight, toTameOrWild, toHairC)
        {
            if (!string.IsNullOrWhiteSpace(toSpecies))
            {
                Species = toSpecies; // If the constructor takes in an empty string, this if statement ensures the default Property value will not be updated
            }
            if (!string.IsNullOrWhiteSpace(toNation)) {
                Nationality = toNation;
            }
        }

        public void GetStats()
        {
            Console.WriteLine($"{Name} is a {Nationality} {Age} year old {Sex} {Species} of the {Family} family from {Origin}, weighing at {Weight} kg.");
        }
    }
}
