using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    // успадкування та перезаписування полів, методів та методів від базового класу
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double side)
            : base(side, side, 60)
        {
        }

        public override double Perimeter()
        {
            return 3 * a;
        }

        public override double Area()
        {
            return (Math.Sqrt(3) / 4) * a * a;
        }
    }
}
