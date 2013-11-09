using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework5
{
        class LinearEquation
        {
            public int A { get; private set; }
            public int B { get; private set; }

            public LinearEquation()
            {
                this.A = 1;
                this.B = 1;
            }

            public LinearEquation(int a, int b)
            {
                this.A = a;
                this.B = b;
            }

            public static void Parse(string input, LinearEquation equation)
            {
                try
                {
                    string[] stringArray = input.Split(',', ' ');
                    if (stringArray.Length < 2)
                    {
                        throw new FormatException("Вы должны ввести хотя бы 2 значения, разделенных запятой или пробелом");
                    }
                    equation.A = int.Parse(stringArray[0]);
                    equation.B = int.Parse(stringArray[1]);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Неправильный ввод данных!");
                    Console.WriteLine(e.Message);
                }
            }

            public static bool ExistsSolution(LinearEquation le1, LinearEquation le2, out string solution)
            {
                try
                {
                    if ((le1.A*le2.B - le1.B*le2.A) == 0)
                    {
                        
                        solution = "X = " + ((double) (le1.B + le2.B)/(le1.A + le2.A)) + "Y.";
                        Console.WriteLine("Система имеет бесчиленное множество решений типа \n{0}", solution);
                        return true;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Система не имеет решений, " +
                                                              "кроме тривиального");
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    solution = "";
                    return false;
                }
            }

        }
}
