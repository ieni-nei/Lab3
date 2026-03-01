using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    // успадкування та перезаписування полів, методів та методів від базового класу
    public class RightTriangle : Triangle
    {
        public RightTriangle(double a, double b)
            : base(a, b, 90)
        {
        }

        public override double Area()
        {
            return 0.5 * a * b;
        }

        public override double Perimeter()
        {
            double c = Math.Sqrt(a * a + b * b);
            return a + b + c;
        }
    }
}
