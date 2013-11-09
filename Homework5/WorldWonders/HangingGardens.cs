using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldWonders
{
    class HangingGardens
    {
        public static string Name = "Hanging Gardens";
        public static string AncientLocation = "Babylon";
        public static string ModernLocation = "Hillah";
        public static string Country = "Iraq";
        public static bool IsInExistence = false;
        public static string DateOfConstruction = "600 B.C.";
        public static string Builder = "Babylonians";
        public static string DateOfDestruction = "100 B.C.";
        public static string CauseOfDestruction = "Earhquakes";

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
