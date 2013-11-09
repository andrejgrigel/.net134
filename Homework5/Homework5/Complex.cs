using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework5
{
    class Complex
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Complex(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Complex operator -(Complex z1, Complex z2)
        {
            return new Complex(z1.X - z2.X, z2.Y - z2.Y);
        }

        public Complex GetConjugate()
        {
            return new Complex(this.X, -this.Y);
        }

        public static Complex operator -(Complex z, int a)
        {
            return new Complex(z.X - a, z.Y);
        }
        public static Complex operator *(Complex z1, Complex z2)
        {
            return new Complex(z1.X * z2.X - z1.Y * z2.Y, z1.X * z2.Y + z1.Y * z2.X);
        }

        public static Complex operator *(Complex z, int a)
        {
            return new Complex(z.X * a, z.Y * a);
        }

        public static Complex operator *(int a, Complex z)
        {
            return z*a;
        }

        public static Complex operator /(Complex z1, Complex z2)
        {
            if (z2.X == 0 && z2.Y == 0)
            {
                throw new DivideByZeroException("Нельзя делить на ноль!");
            }
            else
            {
                return new Complex((z1.X * z2.Y + z1.Y * z2.Y) / (z2.X * z2.X + z2.Y * z2.Y),
                    (z1.Y * z2.X - z1.X * z2.Y) / (z2.X * z2.X + z2.Y * z2.Y));
            }
        }

        public override string ToString()
        {
            if (this.X == 0 & this.Y == 0)
            {
                return " 0";
            }
            else if(this.Y == 0)
            {
                return " " + this.X;
            }
            else if (this.X == 0)
            {
                if (this.Y < 0)
                {
                    return " -" + this.Y + "i";
                }
                else
                {
                    return " " + this.Y + "i";
                }
            }
            else if (this.Y > 0)
            {
                return " " + this.X + " + " + this.Y + "i";
            }
            else
            {
                return " " + this.X + " - " + this.Y + "i";
            }
        }
    }
}
