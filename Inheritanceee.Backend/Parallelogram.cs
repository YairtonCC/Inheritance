using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritanceee.Backend
{

    public class Parallelogram : Rectangle
    {
        private double _h;
        public double H => _h;

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            _h = ValidateH(h);
        }

        public override double GetArea() => (B * _h);
        public override double GetPerimeter() => 2 * (A + B);

        private double ValidateH(double h)
        {
            if (h <= 0) throw new ArgumentException("La altura debe ser positiva.");
            return h;
        }
    }


}


