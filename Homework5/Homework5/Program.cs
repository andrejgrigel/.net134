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
            Complex z = new Complex(1,1);
            Complex z1;
            z1 = z - ((z * z * z - 1) / (3 * z * z));
            Console.WriteLine("z1 ={0}", z1);
            Console.WriteLine("X = {0}, Y = {1}", z1.X, z1.Y);
        }
    }
}
