using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldWonders
{
    class Lighthouse
    {
        public static string Name = "Lighthouse";
        public static string AncientLocation = "Alexandria";
        public static string ModernLocation = "Alexandria";
        public static string Country = "Egypt";
        public static bool IsInExistence = false;
        public static string DateOfConstruction = "280 B.C.";
        public static string Builder = "Ptolemaic Egypt";
        public static string DateOfDestruction = "1303 A.D.";
        public static string CauseOfDestruction = "Crete Earhquake";

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
