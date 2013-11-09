using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearEquation le1 = new LinearEquation(2, 3);
            LinearEquation le2 = new LinearEquation(4, 6);
            string solution;
            bool exists = LinearEquation.ExistsSolution(le1, le2, out solution);

        }
    }
}
