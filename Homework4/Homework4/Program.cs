using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework4
{
    class Program
    {

        static public int[] ChangeArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                while (array[i] == 0)
                {
                    for (int j = i; j < array.Length - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    array[array.Length - 1] = -1;
                }
            }
            return array;
        }

        static public int[] SortArray(int[] array)
        {
            int negative = 0, temp;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    temp = array[negative];
                    array[negative] = array[i];
                    array[i] = temp;
                    negative++;
                }
            }
            return array;
        }

        static public int NumberMatch(int number)
        {
            int[] myArray = new int[100];
            int count = 0;
            Random rand = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(-30, 31);
                if (myArray[i] == number)
                {
                    count++;
                }
            }
                return count;
        }

        static public void ChangeFields(int[,] field, int first, int second)
        {
            int temp;
            for (int i = 0; i < field.GetLength(0); i++)
            {
                temp = field[i, first - 1];
                field[i, first - 1] = field[i, second - 1];
                field[i, second - 1] = temp;
            }


        }

        static public void ShowStringInfo(string input)
        {
            int letters = 0,
                upperCaseLetters = 0,
                lowerCaseLetters = 0,
                digits = 0,
                paddles = 0,
                punctuationMarks = 0;
            foreach (char symbol in input)
            {
                if (Char.IsLetter(symbol))
                {
                    letters++;
                    if (Char.IsUpper(symbol))
                    {
                        upperCaseLetters++;
                    }
                    else
                    {
                        lowerCaseLetters++;
                    }

                }
                else if (Char.IsDigit(symbol))
                {
                    digits++;
                }
                else if (symbol == ' ')
                {
                    paddles++;
                }
                else
                {
                    punctuationMarks++;
                }
            }

            Console.WriteLine("Длина строки составляет {0} символов.", input.Length);
            Console.WriteLine("В строке содержится {0} букв, \nиз них  {1} в верхнем регистре и {2} в нижнем.",
                letters, upperCaseLetters, lowerCaseLetters);
            Console.WriteLine("Кроме того, в строке имеется цифр - {0}, \nпробелов - {1}, \nпрочих знаков пунктуации - {2}.",
                digits, paddles, punctuationMarks);

        }

        static public string ChangeString(string input, char symbol)
        {
            string newString = input.Substring(0, input.LastIndexOf(symbol) + 1);
            newString = newString.Replace(symbol, Char.ToUpper(symbol));
            return newString;
        }

        static public void RunHomework()
        {
            string task, answer, continueTask;
            Console.WriteLine("Привет! Здесь представлены решения домашних заданий к уроку №4.");
            do
            {
                Help.DrawMenu();
                task = Console.ReadLine();
                Console.Clear();
                switch (task)
                {
                    case "1":
                        #region Changing the Array
                        do
                        {
                            int[] myArray = ChangeArray(Help.AskAndParseToArray());
                            Console.WriteLine();
                            Console.WriteLine("Массив после преобразования: ");
                            foreach (int item in myArray)
                            {
                                Console.Write(item);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Нажмите Enter для продолжения или 0 для выхода из программы...");
                            continueTask = Console.ReadLine();
                            Console.Clear();
                        } while (continueTask != "0");
                        break;
                        #endregion
                    case "2":
                        #region Negative First
                        do
                        {
                            int[] myArray = SortArray(Help.AskAndParseToArray());
                            Console.WriteLine();
                            Console.WriteLine("Массив после преобразования: ");
                            foreach (int item in myArray)
                            {
                                Console.Write(item);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Нажмите Enter для продолжения или 0 для выхода из программы...");
                            continueTask = Console.ReadLine();
                            Console.Clear();
                        } while (continueTask != "0");
                        break;
                        #endregion
                    case "3":
                        #region Calculate occurences
                        do
                        {
                            Console.WriteLine("Введите число, количество вхождений которого вы хотите посчитать.");
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine("Количество вхождений числа {0} в массив составляет {1}", number, NumberMatch(number));
                            Console.WriteLine();
                            Console.WriteLine("Нажмите Enter для продолжения или 0 для выхода из программы...");
                            continueTask = Console.ReadLine();
                            Console.Clear();
                        } while (continueTask != "0");
                        break;
                        #endregion
                    case "4":
                        #region Changing rows
                        do
                        {
                            Console.WriteLine("Введите количество столбцов: ");
                            int width = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите количество строк: ");
                            int height = int.Parse(Console.ReadLine());
                            int[,] myField = new int[height, width];
                            Console.WriteLine("Массив до преобразования: ");
                            Console.WriteLine();
                            for (int i = 0; i < height; i++)
                            {
                                for (int j = 0; j < width; j++)
                                {
                                    myField[i, j] = j + 1;
                                    Console.Write(myField[i, j]);
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("Введите порядковый номер столбца, который Вы хотите заменить: ");
                            int first = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите порядковый номер другого столбца, который Вы хотите заменить: ");
                            int second = int.Parse(Console.ReadLine());
                            ChangeFields(myField, first, second);
                            Console.WriteLine("Массив после преобразования: ");
                            for (int i = 0; i < height; i++)
                            {
                                for (int j = 0; j < width; j++)
                                {
                                    Console.Write(myField[i, j]);
                                }
                                Console.WriteLine();

                            }
                            Console.WriteLine("Нажмите Enter для продолжения или 0 для выхода из программы...");
                            continueTask = Console.ReadLine();
                            Console.Clear();
                        } while (continueTask != "0");

                        break;
                        #endregion
                    case "5":
                        #region Info String
                        do
                        {
                            Console.WriteLine("Введит строку, чтобы получить по ней информацию: ");
                            ShowStringInfo(Console.ReadLine());
                            Console.WriteLine("Нажмите Enter для продолжения или 0 для выхода из программы...");
                            continueTask = Console.ReadLine();
                            Console.Clear();
                        } while (continueTask != "0");
                        break;
                        #endregion
                    case "6":
                        #region Updating String
                        do
                        {
                            Console.WriteLine("Введите строку, которую Вы хотите поменять: ");
                            string input = Console.ReadLine();
                            Console.WriteLine("Введите символ, регистр которого надо заменить: ");
                            char symbol = char.Parse(Console.ReadLine());
                            Console.WriteLine("Новая строка выглядит так: \n{0}", ChangeString(input, symbol));
                            Console.WriteLine("Нажмите Enter для продолжения или 0 для выхода из программы...");
                            continueTask = Console.ReadLine();
                            Console.Clear();
                        } while (continueTask != "0");
                        break;
                        #endregion
                }
                Console.WriteLine("Для проверки других заданий нажмите Enter или 0 для завершения программы");
                answer = Console.ReadLine();
                Console.Clear();
            } while (answer != "0");
        }

        static void Main(string[] args)
        {
            RunHomework();
            
        }
    }
}
