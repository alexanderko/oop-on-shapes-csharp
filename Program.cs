using System;

namespace oop_on_shapes
{
    abstract class Shape 
    {
        char color;

        public Shape(char color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return $"Shape of color {color}";
        }

        abstract public double CalculateArea();
    }

    class Circle : Shape
    {
        int radius;

        public Circle(char color, int radius) : base(color)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {
                new Circle('r', 3),
                new Circle('b', 3),
                new Circle('w', 3)
            };

            foreach(var shape in shapes)
            {
                Console.WriteLine(shape);
            }

            double area = GetTotalArea(shapes);
            Console.WriteLine("Area: {0}", area);
        }

        private static double GetTotalArea(Shape[] shapes)
        {
            double area = 0;
            foreach(var shape in shapes)
            {
                area += shape.CalculateArea();
            }
            return area;
        }
    }
}
