using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public static class TriangleFactory
    {
        // визначає який об'єкт створити
        public static Triangle Create(double a, double b, double angle)
        {
            validateTriangle(a, b, angle);

            // 0.0001 пом'якшує помилки порівняння з плаваючою комою 
            if (Math.Abs(angle - 90) < 0.0001)
                return new RightTriangle(a, b);

            if (Math.Abs(a - b) < 0.0001 && Math.Abs(angle - 60) < 0.0001)
                return new EquilateralTriangle(a);

            if (Math.Abs(a - b) < 0.0001)
                return new IsoscelesTriangle(a, b);

            return new GeneralTriangle(a, b, angle);
        }

        // перевіряє умови існування трикутника
        private static void validateTriangle(double a, double b, double angle)
        {
            if (a <= 0 || b <= 0)
                throw new ArgumentException("Сторони мають бути додатніми.");

            if (angle <= 0 || angle >= 180)
                throw new ArgumentException("Кут має бути від нуля до 180.");

            double angleRad = angle * Math.PI / 180;
            double cSquared = a * a + b * b - 2 * a * b * Math.Cos(angleRad);

            if (cSquared <= 0)
                throw new ArgumentException("Невірна розмірність трикутника.");

            double c = Math.Sqrt(cSquared);

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Умова трикутника порушена.");
        }
    }

}
