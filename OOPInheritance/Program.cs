using OOPInheritance.Lifeforms.Animals.Mammals.Homo;
using OOPInheritance.Lifeforms.Animals.Mammals.Ursa;
using OOPInheritance.Lifeforms.Animals.Reptiles;
using OOPInheritance.Lifeforms.Plants.Herbs;

namespace OOPInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BrownBear bear1 = new BrownBear(
                "Ursus arctos arctos", "Brown Bear", "Bear", "Wojtek", 2, 21, "Iran", 67, "Tame");
            PolarBear bear2 = new PolarBear(
                "Ursus maritimus", "Polar Bear", "Bear", "Nanook", 1, 14, "Arctica", 200.7, "Wild", true);
            Chameleon lizard1 = new Chameleon(
                "Archaius tigris", "Chameleon", "Nina", 3, 8, "Seychelles", 2, "Wild", true);
            Snake snake1 = new Snake(
                "Ophiophagus hannah", "Serpent", "Moa", 1, 6, "Thailand", 8, "Wild", 4);

            Sapiens human1 = new Sapiens(
                "Homo sapiens", "Human", "Hominid", "David", 2, 44, "Australia", "Australian", 80, "Tame", "Blonde");
            Sapiens human2 = new Sapiens(
                "", "", "", "", -32, -3, " ", " ", -33.33, " ", " ");
            Sapiens human3 = new Sapiens(
                "Australopithecus afarensis", "Human", "Homonid", "Lucy", 1, 20, "Ethiopia", "Unkown nationality", 60, "Wild", "Dark Brown");

            Mint plant1 = new Mint("Melissa officinalis", "Lemon balm", "Mint", 3, 2, "Italy", 30, "sour");




            bear1.GetStats();
            bear1.MakeSound();
            bear2.GetStats();
            bear2.MakeSound();

            Console.WriteLine(Environment.NewLine);

            lizard1.MakeSound();
            lizard1.IsCamoflauged();

            Console.WriteLine(Environment.NewLine);

            snake1.MakeSound();
            for (Int16 i=0; i < 5; i++) {
                snake1.IsShedding();
            }

            Console.WriteLine(Environment.NewLine);

            human1.GetStats();
            human1.MakeSound();

            human2.GetStats();
            human2.MakeSound();

            human3.GetStats();
            human3.MakeSound();

            Console.WriteLine(Environment.NewLine);

            plant1.GetStats();
            plant1.GetSmell();
        }
    }
}
