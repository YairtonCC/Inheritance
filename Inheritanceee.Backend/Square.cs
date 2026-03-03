using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritanceee.Backend
{

    public class Square : GeometricFigure
    {
        private double _a;
        public double A => _a;

        public Square(string name, double a) : base(name)
        {
            _a = ValidateA(a);
        }

        public override double GetArea() => _a * _a;
        public override double GetPerimeter() => 4 * _a;

        private double ValidateA(double a)
        {
            if (a <= 0) throw new ArgumentException("El lado debe ser positivo.");
            return a;
        }
    }

}


