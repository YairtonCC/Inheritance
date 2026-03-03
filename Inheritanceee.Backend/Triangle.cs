using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritanceee.Backend
{ 
    public class Triangle : Rectangle
    {
        private double _c;
        public double C => _c;

        private double _h;
        public double H => _h;

        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            _c = ValidateC(c);
            _h = ValidateH(h);
        }

        public override double GetArea() => (B * _h) / 2;
        public override double GetPerimeter() => A + B + _c;

        private double ValidateC(double c)
        {
            if (c <= 0) throw new ArgumentException("El lado C debe ser positivo.");
            return c;
        }

        private double ValidateH(double h)
        {
            if (h <= 0) throw new ArgumentException("La altura debe ser positiva.");
            return h;
        }
    }


}


