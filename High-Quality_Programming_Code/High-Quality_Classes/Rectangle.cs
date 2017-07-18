using System;

namespace Abstraction
{
    public class Rectangle : Figure
    {
        private double width;
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;

                if (width <= 0)
                {
                    throw new ArgumentException("The width of the rectangle should be positive.");
                }
            }
        }

        private double length;
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;

                if (length <= 0)
                {
                    throw new ArgumentException("The length of the rectangle should be positive.");
                }
            }
        }

        public Rectangle(double width, double length)
        {
            this.Width = width;
            this.Length = length;
        }

        public double PerimeterOfRectangle()
        {
            double perimeter = 2 * (this.Width + this.Length);
            return perimeter;
        }

        public double AreaOfRectangle()
        {
            double area = this.Width * this.Length;
            return area;
        }
    }
}
