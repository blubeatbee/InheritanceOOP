using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance.Lifeforms.Plants
{
    internal abstract class Plant : Life
    {
        // Properties with default values
        protected string Annual { get; set; } = "Annual";
        protected double Length { get; set; } = 50;

        protected Plant(string toNomen, int toAnnual, int toAge, string toOrigin, double toLength) : base(toNomen, toAge, toOrigin)
        {
            if (toAnnual < toAge) { 
                toAnnual = toAge;  // Ensures plant lifecycle cannot be less than its age (because that would be impossible)
            }
            if (toAnnual <= 0) { 
                toAnnual = 1; // If plant lifecycle is 0 or negative number, make it an annual plant
            } 
            else if (toAnnual > 3) { 
                toAnnual = 3; // If plant lifecycle is over 3, make it a perennial plant
            } 
            switch (toAnnual) {
                case 1: Annual = "Annual"; break;
                case 2: Annual = "Biennial"; break;
                case 3: Annual = "Perennial"; break;
                default: Annual = "Perennial"; break;
            }

            if(toLength > 0)
            {
                Length = toLength;
            }
        }

        // Abstract method which forces sub class to include their own defined GetSmell() method
        public abstract void GetSmell();
        
    }
}
