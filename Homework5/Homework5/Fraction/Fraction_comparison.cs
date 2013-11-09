using System;

namespace Homework5.Fraction
{
    public partial class Fraction
    {
        public static bool operator ==(Fraction f, int a)
        {
            return (f.Numerator == a*f.Denumerator);
        }

        public static bool operator !=(Fraction f, int a)
        {
            return !(f == a);
        }

        public static bool operator ==(int a, Fraction f)
        {
            return (f == a);
        }

        public static bool operator !=(int a, Fraction f)
        {
            return f != a;
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return (f1.Numerator*f2.Denumerator == f1.Denumerator*f2.Numerator);
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }

        public static bool operator ==(Fraction f, double x)
        {
            return f == (Fraction) x;
        }

        public static bool operator !=(Fraction f, double x)
        {
            return !(f == x);
        }

        public static bool operator ==(double x, Fraction f)
        {
            return f == x;
        }

        public static bool operator !=(double x, Fraction f)
        {
            return f != x;
        }

        public static bool operator >(Fraction f, int a)
        {
            return (f.Numerator > a*f.Denumerator);
        }

        public static bool operator <(Fraction f, int a)
        {
            return (f.Numerator < a * f.Denumerator);
        }

        public static bool operator >(int a, Fraction f)
        {
            return f < a;
        }

        public static bool operator <(int a, Fraction f)
        {
            return f > a;
        }

        public static bool operator >(Fraction f1, Fraction f2)
        {
            return f1.Numerator*f2.Denumerator > f2.Numerator*f1.Denumerator;
        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            return f1.Numerator * f2.Denumerator < f2.Numerator * f1.Denumerator;
        }

        public static bool operator >(Fraction f, double x)
        {
            return f > (Fraction) x;
        }

        public static bool operator <(Fraction f, double x)
        {
            return f < (Fraction)x;
        }

        public static bool operator >(double x, Fraction f)
        {
            return f < x;
        }

        public static bool operator <(double x, Fraction f)
        {
            return f > x;
        }

    }
}

