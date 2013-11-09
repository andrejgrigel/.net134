using System;

namespace Homework5.Fraction
{
    public partial class Fraction
    {
        public static Fraction operator /(Fraction f, int a)
        {
            Fraction f2 = new Fraction(f.Numerator, f.Denumerator * a);
            return SimplifyFraction(f2);
        }

        public static Fraction operator /(int a, Fraction f)
        {
            Fraction f2 = new Fraction(a * f.Denumerator, f.Numerator);
            return SimplifyFraction(f2);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction(f1.Numerator * f2.Denumerator, f1.Denumerator * f2.Numerator);
            return SimplifyFraction(f3);
        }

        public static Fraction operator /(Fraction f, double x)
        {
            return f/(Fraction) x;
        }

        public static Fraction operator /(double x, Fraction f)
        {
            return (Fraction) x/f;
        }
    }
}

