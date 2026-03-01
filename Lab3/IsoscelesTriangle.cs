using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    // успадкування та перезаписування полів, методів та методів від базового класу
    public class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double equalSide, double baseSide)
            : base(equalSide, equalSide,
                   2 * Math.Asin(baseSide / (2 * equalSide)) * 180 / Math.PI)
        {
        }

        public override double Perimeter()
        {
            return 2 * a + b;
        }

        public override double Area()
        {
            double height = Math.Sqrt(a * a - (b * b) / 4);
            return (b * height) / 2;
        }
    }
}
