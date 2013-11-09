using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework4
{
    class Help
    {
        public static void DrawMenu()
        {
            Console.WriteLine("Для перехода к просмотру решений выберите номер задания от 1 до 6.");
            Console.WriteLine("1. Программа для сжатия массива");
            Console.WriteLine("2. Программа для преобразования массива");
            Console.WriteLine("3. Программа, которая считает, сколько раз число встречается в массиве.");
            Console.WriteLine("4. Программа для смены столбцов местами");
            Console.WriteLine("5. Программа для вывода статистики по введенной строке");
            Console.WriteLine("6. Программа для преобразования строки.");
            Console.WriteLine("7. Программа для рисования ромба.");
        }

        public static int[] AskAndParseToArray()
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите последовательность чисел, разделенных запятыми: ");
                    string[] newString = Console.ReadLine().Split(',');
                    int[] myArray = new int[newString.Length];
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        myArray[i] = int.Parse(newString[i]);
                    }
                    Console.WriteLine("Массив до преобразования: ");

                    foreach (int number in myArray)
                        Console.Write(number);

                    return myArray;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неправильный формат ввода данных!");
                }
            }
        }
    }
}
