using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritanceee.Backend
{
    public class Circle : GeometricFigure
    {
        private double _r;
        public double R => _r;

        public Circle(string name, double r) : base(name)
        {
            _r = ValidateR(r);
        }

        public override double GetArea() => Math.PI * _r * _r;
        public override double GetPerimeter() => 2 * Math.PI * _r;

        private double ValidateR(double r)
        {
            if (r <= 0) throw new ArgumentException("El radio debe ser positivo.");
            return r;
        }
    }

}
