using System;
namespace Aanchal
{
    public class Circle : Shape
    {
        public Circle(double radius) { Radius = radius; }
        public override double Area => Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        public override double Perimeter => Math.Round(Math.PI * 2 * Radius, 2);
        public double Circumference => Perimeter;
        public double Radius { get; }
        public double Diameter => Radius * 2;
    }
}