using System;

namespace Homework5.Fraction
{
    public partial class Fraction
    {
        public static Fraction operator *(Fraction f, int a)
        {
            Fraction f2 = new Fraction(f.Numerator * a, f.Denumerator);
            return SimplifyFraction(f2);
        }

        public static Fraction operator *(int a, Fraction f)
        {
            return f*a;
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction f3 = new Fraction(f1.Numerator * f2.Numerator, f1.Denumerator * f2.Denumerator);
            return SimplifyFraction(f3);
        }

        public static Fraction operator *(Fraction f, double x)
        {
            return f*(Fraction) x;
        }

        public static Fraction operator *(double x, Fraction f)
        {
            return f*x;
        }

    }
}

