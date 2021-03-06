﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorldWonders
{
    class Colossus
    {
        public static string Name = "Colossus";
        public static string AncientLocation = "Rhodes";
        public static string ModernLocation = "Rhodes";
        public static string Country = "Greece";
        public static bool IsInExistence = false;
        public static string DateOfConstruction = "292 B.C.";
        public static string Builder = "Greeks";
        public static string DateOfDestruction = "226 B.C.";
        public static string CauseOfDestruction = "Rhodes Earhquake";

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
