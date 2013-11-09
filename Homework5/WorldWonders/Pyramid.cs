using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldWonders
{
    class Pyramid
    {
        public static string Name = "Great Pyramid";
        public static string AncientLocation = "Giza Necropolis";
        public static string ModernLocation = "Giza";
        public static string Country = "Egypt";
        public static bool IsInExistence = true;
        public static string DateOfConstruction = "2584 B.C.";
        public static string Builder = "Egyptians";
        public static string DateOfDestruction;
        public static string CauseOfDestruction;

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
