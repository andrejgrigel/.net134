using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldWonders
{
    class ArtemisTemple
    {
        public static string Name = "Temple of Artemis";
        public static string AncientLocation = "Ephesus";
        public static string ModernLocation = "Izmir";
        public static string Country = "Turkey";
        public static bool IsInExistence = false;
        public static string DateOfConstruction = "550 B.C.";
        public static string Builder = "Lydians";
        public static string DateOfDestruction = "262 B.C.";
        public static string CauseOfDestruction = "Plundering by the Goths";

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
