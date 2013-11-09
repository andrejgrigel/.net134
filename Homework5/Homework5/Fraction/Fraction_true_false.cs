using System;

namespace Homework5.Fraction
{
    public partial class Fraction
    {
        public static bool operator true(Fraction f)
        {
            return f.Numerator < f.Denumerator;
        }

        public static bool operator false(Fraction f)
        {
            return f.Denumerator > f.Numerator;
        }

    }
}

