using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritanceee.Backend
{

    public class Rhombus : Square
    {
        private double _d1, _d2;
        public double D1 => _d1;
        public double D2 => _d2;

        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            _d1 = ValidateD1(d1);
            _d2 = ValidateD2(d2);
        }

        public override double GetArea() => (_d1 * _d2) / 2;
        public override double GetPerimeter() => 4 * A;

        private double ValidateD1(double d1)
        {
            if (d1 <= 0) throw new ArgumentException("La diagonal debe ser positiva.");
            return d1;
        }

        private double ValidateD2(double d2)
        {
            if (d2 <= 0) throw new ArgumentException("La diagonal debe ser positiva.");
            return d2;
        }
    }
}


