using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    internal class Complex
    {
        public double A { get; set; }
        public double B { get; set; }

        public Complex(double a, double b)
        {
            A = a;
            B = b;
        }
        public override string? ToString()
        {
            if (B > 0)
                return A + "+" + B + "i";
            else if (B < 0)
                return A + "-" + Math.Abs(B) + "i";
            return A.ToString();
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.A + c2.A, c2.B + c2.B);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.A - c2.A, c2.B - c2.B);
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.A * c2.A - c1.B * c2.B,
                c1.A * c2.B - c2.A * c1.B);
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            return new Complex((c1.A * c2.A - c1.B * c2.B) / (c2.B * c2.B + c2.A * c2.A),
                            (c1.A * c2.B - c2.A * c1.B) / (c2.B * c2.B + c2.A * c2.A));
        }
        public static bool operator ==(Complex c1, Complex c2)
        {
            return (c1.A == c2.A) && (c1.B==c2.B);
        }
        public static bool operator !=(Complex c1, Complex c2)
        {
            return (c1.A != c2.A)||(c1.B != c2.B);
        }
    }
}
