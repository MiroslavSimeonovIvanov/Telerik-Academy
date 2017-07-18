using System;

namespace Abstraction
{
    public class Circle : Figure
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;

                if (radius <= 0)
                {
                    throw new ArgumentException("Radius should be positive.");
                }
            }
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double PerimeterOfCircleByGivenRadius()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public double AreaOfCircleByGivenRadius()
        {
            double area = Math.PI * this.Radius * this.Radius;
            return area;
        }
    }
}
