using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework4
{
    class Diamond
    {
        public static void DrawDiamond(int width, bool isEmpty)
        {
            int remainder = (width - 1) % 2;
            if (!isEmpty)
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        int temp = Math.Abs(width / 2 - i - remainder);
                        if ((j >= temp) && (j <= Math.Abs(width - 1 - temp - remainder)))
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        int temp = Math.Abs(width / 2 - i - remainder);
                        if ((j == temp) || (j == Math.Abs(width - 1 - temp - remainder)))
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine();
                }
            }

        }

    }
}
