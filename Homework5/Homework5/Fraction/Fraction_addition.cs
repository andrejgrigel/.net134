namespace Homework5.Fraction
{
    public partial class Fraction
    {
        public static Fraction operator +(Fraction fraction1, int a)
        {
            Fraction f2 = new Fraction(fraction1.Numerator + a * fraction1.Denumerator, 
                fraction1.Denumerator);
            return SimplifyFraction(f2);
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            Fraction simpleFraction = new Fraction(1,1);

            simpleFraction.Numerator = fraction1.Numerator * fraction2.Denumerator + fraction2.Numerator * fraction1.Denumerator;
            simpleFraction.Denumerator = fraction1.Denumerator * fraction2.Denumerator;

            return SimplifyFraction(simpleFraction);
        }

        public static Fraction operator +(Fraction fraction1, double x)
        {
            return fraction1 + (Fraction)x;
        }

        public static Fraction operator +(int a, Fraction fraction1)
        {
            return fraction1 + a;
        }

        public static Fraction operator +(double x, Fraction fraction1)
        {
            return fraction1 + x;
        }

    }
}

