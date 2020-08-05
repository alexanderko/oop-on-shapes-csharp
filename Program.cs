using System;

namespace oop_on_shapes
{
    class Shape 
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {
                new Shape('r'),
                new Shape('b'),
                new Shape('w')
            };

            foreach(var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
