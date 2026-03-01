using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    // абстрактний батьківський клас, що дозволяє створювати похідні класи
    public abstract class Triangle
    {
        protected double a;      // перша сторона
        protected double b;      // друга сторона
        protected double angle;  // кут між ними

        protected Triangle(double a, double b, double angle)
        {
            this.a = a;
            this.b = b;
            this.angle = angle;
        }
        
        // методи з ключовим словом, що дозволяє їм бути перезаписаними
        public virtual double Perimeter()
        {
            // third side using Law of Cosines
            double c = Math.Sqrt(a * a + b * b -
                       2 * a * b * Math.Cos(angle * Math.PI / 180));
            return a + b + c;
        }

        public virtual double Area()
        {
            return 0.5 * a * b *
                   Math.Sin(angle * Math.PI / 180);
        }
    }
}
