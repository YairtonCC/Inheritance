using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritanceee.Backend
{
    public class Rectangle : Square
    {
        private double _b;
        public double B => _b;

        public Rectangle(string name, double a, double b) : base(name, a)
        {
            _b = ValidateB(b);
        }

        public override double GetArea() => A * _b;
        public override double GetPerimeter() => 2 * (A + _b);

        private double ValidateB(double b)
        {
            if (b <= 0) throw new ArgumentException("El lado debe ser positivo.");
            return b;
        }
    }

}

