using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance.Lifeforms.Animals
{
    internal class Animal : Life
    {
        // Properties with default values
        protected string Name { get; set; } = "John"; 
        protected string Sex { get; set; } = "Neuter";
        protected double Weight { get; set; } = 10;
        protected string TameOrWild { get; set; } = "Unknown";

        protected Animal(string toNomen, string toName, int toSex, int toAge, string toOrigin, double toWeight, string toTameOrWild) : base(toNomen, toAge, toOrigin)
        {
            if (!string.IsNullOrWhiteSpace(toName)) {
                Name = toName; // If variable empty, default Property value will be kept
            }

            switch (toSex) // Because toSex can only contain integer numbers, this switch translates that into proper sexual terms depending on the number
            {
                case 0: Sex = "Neuter"; break;
                case 1: Sex = "Female"; break;
                case 2: Sex = "Male"; break;
                case 3: Sex = "Hermaphrodite"; break;
                default: Sex = "Neuter"; break; // If integer number doesn't match, sets sex to "neuter" by default
            }
            if (toAge > 0) { 
                Age = toAge; // If variable is 0 or a negative number, default Property value will be kept
            }

            if (!string.IsNullOrWhiteSpace(toOrigin)) {
                Origin = toOrigin; // If variable empty, default Property value will be kept
            }

            if (toWeight > 0) {
                Weight = toWeight; // If variable is 0 or a negative number, default Property value will be kept
            }

            if (!string.IsNullOrWhiteSpace(toTameOrWild)) {
                TameOrWild = toTameOrWild; // If variable empty, default Property value will be kept
            }
        }

        public void GetHunger()
        {
            Console.WriteLine($"{Name} is feeling hungry.");
        }
        public void GetEat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
        public void GetSleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
        public void GetDeath()
        {
            Console.WriteLine($"{Name} has died. RIP in peace.");
        }

    }
}
