using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldWonders
{
    class Mausoleum
    {
        public static string Name = "Mausoleum";
        public static string AncientLocation = "Helicarnassus";
        public static string ModernLocation = "Bodrum";
        public static string Country = "Turkey";
        public static bool IsInExistence = false;
        public static string DateOfConstruction = "351 B.C.";
        public static string Builder = "Carians";
        public static string DateOfDestruction = "1494 A.D.";
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
