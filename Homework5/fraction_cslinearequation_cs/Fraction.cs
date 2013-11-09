using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework5
{
    class Fraction
    {
        int denum;
        public int Numerator { get; private set; }
        public int Denumerator 
        {
            get {return denum;}
            set { denum = value != 0 ? value : 1;}
        }

        public Fraction(int num, int denum)
        {
            this.Numerator = num;
            this.Denumerator = denum;
        }

        public void ShowFraction()
        {
            Console.WriteLine("Numerator - {0}, Denumerator - {1}", this.Numerator, this.Denumerator);
        }

        public static  int GetMaxCommonDivisor(int a, int b)
        {
            int min = Math.Min(a, b);
            for (int i = min; i >= 1; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    return i;
                }
            }
            return 1;
        }

        public static void SimplifyFraction (ref int a, ref int b)
        {
            int maxDivisor = GetMaxCommonDivisor(a, b);
            a /= maxDivisor;
            b /= maxDivisor;
        }

        public static Fraction operator+ (Fraction fraction1, int a)
        {
            return new Fraction(fraction1.Numerator + a * fraction1.Denumerator, fraction1.Denumerator);
        }

        public static Fraction operator+ (Fraction fraction1, Fraction fraction2)
        {
            if (fraction1.Denumerator == fraction2.Denumerator)
            {
                return new Fraction(fraction1.Numerator + fraction2.Numerator, fraction1.Denumerator);
            }
            else
            {
                int newNum = fraction1.Numerator * fraction2.Denumerator + fraction2.Numerator * fraction1.Denumerator;
                int newDenum = fraction1.Denumerator * fraction2.Denumerator;
                return new Fraction(newNum, newDenum);
            }
        }

        public static explicit operator Fraction(double x)
        {
            int b = 1;
            double remainder = x - (int)x;

            while (remainder != 0)
            {
                b *= 10;
                x *= 10;
                remainder = x - (int)x;
            }

            return new Fraction((int)x, b);
        }
    }
}
