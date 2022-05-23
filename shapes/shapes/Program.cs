using System;
namespace Aanchal
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, We are exploring inheritance in Class");
            Shape[] shapes = { new Rectangle(10, 12), new Square(5), new Circle(3) };
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape}: area, {Shape.GetArea(shape)};" +
                    $"perimeter, {Shape.GetArea(shape)}");
                if (shape is Rectangle rect)
                {
                    Console.WriteLine($" Is Square: {rect.IsSquare()}, Diagonal: {rect.Diagonal}");
                    continue;
                }
                if (shape is Square sq)
                {
                    Console.WriteLine($" Diagonal : {sq.Diagonal}");
                    continue;
                }
            }
        }

    }
}