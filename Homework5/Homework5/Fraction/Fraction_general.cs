using System;

namespace Homework5.Fraction
{
    public partial class Fraction
    {
        int _denum;
        public int Numerator { get; private set; }
        public int Denumerator
        {
            get { return _denum; }
            set { _denum = value != 0 ? value : 1; }
        }

        public Fraction(int num, int denum)
        {
            this.Numerator = num;
            this.Denumerator = denum;
        }

        public void ShowFraction()
        {
            Console.WriteLine("Дробь {0} / {1}", this.Numerator, this.Denumerator);
        }

        public static int GetMaxCommonDivisor(int a, int b)
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

        public static Fraction SimplifyFraction(Fraction fraction)
        {
            int maxDivisor = GetMaxCommonDivisor(fraction.Numerator, fraction.Denumerator);
            return new Fraction(fraction.Numerator / maxDivisor, fraction.Denumerator / maxDivisor);
        }

        public static explicit operator Fraction(double x)
        {
            int b = 1;
            double remainder = x - (int)x;

            while (remainder != 0.0)
            {
                b *= 10;
                x *= 10;
                remainder = x - (int)x;
            }

            Fraction f = new Fraction((int)x, b);
            return SimplifyFraction(f);
        }

    }
}

