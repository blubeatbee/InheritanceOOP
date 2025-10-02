using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance.Lifeforms
{
    internal abstract class Life
    {
        protected string Binomen { get; set; } = "Homo sapien";
        protected int Age { get; set; } = 1;
        protected string Origin { get; set; } = "Sweden";

        protected Life (string toNomen, int toAge, string toOrigin)
        {
            if (!string.IsNullOrWhiteSpace(toNomen)){
                Binomen = toNomen; // If variable empty, default Property value will be kept
            }
            if (toAge > 0) {
                Age = toAge; // If variable is 0 or a negative number, default Property value will be kept
            }
            if (!string.IsNullOrWhiteSpace(toOrigin)) {
                Origin = toOrigin; // If variable empty, default Property value will be kept
            }
        }
    }
}
