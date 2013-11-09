using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldWonders
{
    class ZeusStatue
    {
        public static string Name = "Statue of Zeus";
        public static string AncientLocation = "Olympia";
        public static string ModernLocation = "Olympia";
        public static string Country = "Greece";
        public static bool IsInExistence = false;
        public static string DateOfConstruction = "466 B.C.";
        public static string Builder = "Greeks";
        public static string DateOfDestruction = "5th century AD";
        public static string CauseOfDestruction = "Fire";

        public static void ShowInfo()
        {
            Console.WriteLine("The {0} was built in {1} in {2} by {3}.", 
                Name, DateOfConstruction, AncientLocation, Builder);
            Console.WriteLine("Now it is in {0}, {1}.", ModernLocation, Country);
            if (IsInExistence)
            {
                Console.WriteLine("This wonder is still in existence.");
            }
            else
            {
                Console.WriteLine("It was destroyed by {0} in {1}", CauseOfDestruction, DateOfDestruction);
            }
        }

    }
}
