using System;

namespace GeometryShape
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Стороны должны быть положительными");

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Треугольник не существует");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public override double Perimeter()
        {
            return SideA + SideB + SideC;
        }

        public override string ToString()
        {
            return $"Triangle: Sides={SideA},{SideB},{SideC}";
        }
    }
}