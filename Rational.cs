using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueList
{
    public class Rational
    {
        private double _value;

        public double Value
        {
            get
            {
                return _value;
            }

            set
            {
                if (Q != 0)
                {
                    _value = P / Q;
                }
                else
                {
                    _value = 0;
                }
            }

        }
        public int P { get; set; }
        public int Q { get; set; }

        public Rational(int p, int q)
        {
            this.P = p;
            this.Q = q;
            this.Value = 0; // Calls to setter method
        }

        public bool GreaterThan (Rational rational)
        {
            if (this.Value == 0)
            {
                if (rational.Value >= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            if (rational.Value == 0)
            {
                if (this.Value > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            int numerator = this.P * rational.Q;
            int b = this.Q * rational.P;

            if (numerator > b)
            {
                return true;
            }

            return false;
        }

        public bool Equals (Rational rational)
        {
            if (this.Value == 0)
            {
                if (rational.Value == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (rational.Value == 0)
            {
                if (this.Value >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            int numerator = this.P * rational.Q;
            int denominator = this.Q * rational.P;

            if (numerator == denominator)
            {
                return true;
            }

            return false;
        }

        public double Plus (Rational rational)
        {
            if (this.Q == 0 || rational.Q == 0)
            {
                throw new ArithmeticException();
            }
            int numerator = this.P * rational.Q + this.Q * rational.P;
            int denominator = this.Q * rational.Q;

            return numerator / denominator;
        }

        public double Minus (Rational rational)
        {
            if (this.Q == 0 || rational.Q == 0)
            {
                throw new ArithmeticException();
            }
            int numerator = this.P * rational.Q - this.Q * rational.P;
            int denominator = this.Q * rational.Q;

            return numerator / denominator;
        }

        public double Multiply (Rational rational)
        {
            if (this.Q == 0 || rational.Q == 0)
            {
                throw new ArithmeticException();
            }
            int numerator = this.P * rational.P;
            int denominator = this.Q * rational.Q;

            return numerator / denominator;
        }

        public override string ToString()
        {
            if (this.Value == 0)
            {
                return "0";
            }

            return $"{this.P}/{this.Q}";
        }
    }
}
