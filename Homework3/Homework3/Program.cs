using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void IsEven()
        {
            Console.WriteLine("Эта программа определяет, является ли число четным.");
            string answer;
            do
            {
                Console.WriteLine("Введите целое число: ");
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("Число {0} четное.", number);
                }
                else
                {
                    Console.WriteLine("Число {0} нечетное.", number);
                }
                Console.WriteLine("Для продолжения работы в программе нажмите Enter или 0 для завершения программы");
                answer = Console.ReadLine();
                Console.Clear();
            } while (answer != "0");

        }

        static void DigitCalc()
        {
            Console.WriteLine("Эта программа считает количество цифр в числе, а также сумму этих чисел.");
            string answer;
            do
            {
                Console.WriteLine("Введите целое число: ");
                int number = int.Parse(Console.ReadLine());
                int numOfDigits = 0;
                int sumOfDigits = 0;
                if (number < 10)
                {
                    numOfDigits = 1;
                    sumOfDigits = number;
                }
                else
                {
                    while (number > 0)
                    {
                        numOfDigits++;
                        sumOfDigits += number % 10;
                        number /= 10;
                    }
                }
                Console.WriteLine("Количество цифр в введенном числе: {0}.", numOfDigits);
                Console.WriteLine("Сумма цифр в введенном числе: {0}", sumOfDigits);
                Console.WriteLine("Для продолжения нажмите Enter или 0 для завершения программы");
                answer = Console.ReadLine();
                Console.Clear();
            } while (answer != "0");
        }

        static void InchCmConverter()
        {
            Console.WriteLine("Это программа Дюймосантиметровый Преобразователь.");
            string answer, choice;
            do
            {
                Console.WriteLine("Если Вы желаете перевести дюймы в сантиметры, нажмите 1.");
                Console.WriteLine("Если Вы хотите перевести сантиметры в дюймы, нажмите 2.");
                choice = Console.ReadLine();
                double inches, centimeters;
                switch (choice)
                {
                    case "1":
                        Console.Write("Введите количество дюймов: ");
                        inches = double.Parse(Console.ReadLine());
                        centimeters = inches * 2.54;
                        Console.WriteLine("{0} дюймов составляет {1} сантиметров.", inches, centimeters);
                        break;
                    case "2":
                        Console.Write("Введите количество сантиметров: ");
                        centimeters = double.Parse(Console.ReadLine());
                        inches = centimeters / 2.54;
                        Console.WriteLine("{0} сантиметров составляет {1} дюймов.", centimeters, inches);
                        break;
                }
                Console.WriteLine("Для продолжения нажмите Enter или 0 для завершения программы");
                answer = Console.ReadLine();
                Console.Clear();
            } while (answer != "0");
        }

        static void DrawLine()
        {
            Console.WriteLine("Используя эту программу, Вы можете нарисовать линию из символов.");
            string answer, direction;
            do
            {
                do
                {
                    Console.Write("Введите 1, если желаете нарисовать горизонтальную линию" +
                        "\n или введите 2, если желаете нарисовать вертикальную линию: ");
                    direction = Console.ReadLine();
                } while (direction != "1" && direction != "2");

                Console.Write("Введите символ, которым бы Вы хотели нарисовать линию: ");
                char symbol = char.Parse(Console.ReadLine());
                Console.Write("Введите количество символов, из которых будет состоять линия: ");
                int numOfSymbols = int.Parse(Console.ReadLine());
                switch (direction)
                {
                    case "1":
                        for (int i = 0; i < numOfSymbols; i++)
                        {
                            Console.Write(symbol);
                        }
                        break;
                    case "2":
                        for (int i = 0; i < numOfSymbols; i++)
                        {
                            Console.WriteLine(symbol);
                        }
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Нажмите Enter для продолжения или 0 для выхода из программы...");
                answer = Console.ReadLine();
                Console.Clear();
            } while (answer != "0");
        }

        static void SumOddNumbers()
        {
            Console.WriteLine("Эта программа суммирует нечетные числа из заданного диапазона (включительно).");
            string answer;
            int min, max, sumOfOddNumbers=0;
            do
            {
                do
                {
                    Console.WriteLine("Введите нижнюю границу диапазона: ");
                    min = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите верхнюю границу диапазона: ");
                    max = int.Parse(Console.ReadLine());
                    if (min > max)
                    {
                        Console.WriteLine("Нижняя граница не может быть больше либо равна верхней границе.");
                    }
                } while (min >= max);
                for (int i = min; i < max + 1; i++)
                {
                    if (i % 2 != 0)
                    {
                        sumOfOddNumbers += i;
                    }
                }
                Console.WriteLine("Сумма нечетных чисел в диапазоне от {0} до {1} равна {2}", min, max, sumOfOddNumbers);
                Console.WriteLine("Нажмите Enter для продолжения или 0 для выхода из программы...");
                answer = Console.ReadLine();
                Console.Clear();
            } while (answer != "0");
        }

        static void Factorial()
        {
            string answer;
            int number, factorial;
            Console.WriteLine("Эта программа считает факториал заданного числа.");
            do
            {
                factorial = 1;
                do
                {
                    Console.WriteLine("Введите положительное число, факториал которого надо посчитать: ");
                    number = int.Parse(Console.ReadLine());
                } while (number < 0);
                if (number != 0)
                {
                    for (int i = 1; i < number + 1; i++)
                    {
                        factorial *= i;
                    }
                }
                Console.WriteLine("Факториал числа {0} равен {1}.", number, factorial);
                Console.WriteLine("Нажмите Enter для продолжения или 0 для выхода из программы...");
                answer = Console.ReadLine();
                Console.Clear();
            } while (answer != "0");
        }

        static void DrawMenu()
        {
            Console.WriteLine("Для перехода к просмотру решений выберите номер задания от 1 до 6.");
            Console.WriteLine("1. Программа, определяющая, целое ли число.");
            Console.WriteLine("2. Программа, определяющая количество и сумму цифр в числе.");
            Console.WriteLine("3. Программа-конвертер между дюймами и сантиметрами.");
            Console.WriteLine("4. Программа, которая рисует линию с задаными от пользователя параметрами.");
            Console.WriteLine("5. Программа, суммирующая нечетные числа в заданном диапазоне.");
            Console.WriteLine("6. Программа для расчета факториала заданного числа");
        }

        static void Main(string[] args)
        {
            string task, answer;
            Console.WriteLine("Привет! Здесь представлены решения домашних заданий к уроку №3.");
            do
            {
                DrawMenu();
                task = Console.ReadLine();
                Console.Clear();
                switch (task)
                {
                    case "1":
                        IsEven();
                        break;
                    case "2":
                        DigitCalc();
                        break;
                    case "3":
                        InchCmConverter();
                        break;
                    case "4":
                        DrawLine();
                        break;
                    case "5":
                        SumOddNumbers();
                        break;
                    case "6":
                        Factorial();
                        break;
                }
                Console.WriteLine("Для проверки других заданий нажмите Enter или 0 для завершения программы");
                answer = Console.ReadLine();
                Console.Clear();
            } while(answer != "0");
        }
    }
}
