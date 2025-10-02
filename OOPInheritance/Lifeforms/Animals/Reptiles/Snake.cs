using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance.Lifeforms.Animals.Reptiles
{
    internal class Snake : Animal
    {
        // Properties with default values
        protected string Family { get; set; } = "Snake";
        protected int DaysLeftToShed { get; set; } = 3; // This Property will be used to count down when it's time to for the snake to shed its skin in ShedSkin() method
        private int MaxLeftToShed { get; set; } = 3; // This Property will be used to reset the number of days in ShedSkin() method. Must have the same value as DaysLeftToShed

        public Snake(string toNomen, string toFamily, string toName, int toSex, int toAge, string toOrigin, double toWeight, string toTameOrWild, int toLeftToShed) : base(toNomen, toName, toSex, toAge, toOrigin, toWeight, toTameOrWild)
        {
            if (!string.IsNullOrWhiteSpace(toFamily)) {
                Family = toFamily; // If the constructor takes in an empty string, this if statement ensures the default Property value will not be updated
            }
            if (toLeftToShed > 0) {
                MaxLeftToShed = DaysLeftToShed = toLeftToShed; // MaxLeftToShed and DaysLeftToShed will share the same number of days
            }
        }

        public void IsShedding()
        {
            if (DaysLeftToShed > 7) {
                Console.WriteLine($"It's not yet time to shed for {Name}.");
                DaysLeftToShed--;
            }
            else if (DaysLeftToShed <= 7 && DaysLeftToShed > 1) {
                Console.WriteLine($"{DaysLeftToShed} left before it's time for {Name} to shed its skin.");
                DaysLeftToShed--;
            }
            else if (DaysLeftToShed == 1) {
                Console.WriteLine($"{Name} is about to shed! Come back tomorrow!");
                DaysLeftToShed--;
            }
            else {
                Console.WriteLine($"{Name} just shedded its skin. Look how fresh {Name} looks now!");
                DaysLeftToShed = MaxLeftToShed; // Resets the days left to shed
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} made a noise! \"Hiss!\"");
        }
    }
}
