using System;

using System.Collections.Generic;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Минимальные и максимальные значения для некоторых типов данных CTS:");
        Console.WriteLine("-------------------------------------------------------------");

        Console.WriteLine("Минимальное и максимальное значение для типа sbyte:");
        Console.WriteLine($"Минимальное: {sbyte.MinValue}");
        Console.WriteLine($"Максимальное: {sbyte.MaxValue}");

        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Минимальное и максимальное значение для типа byte:");
        Console.WriteLine($"Минимальное: {byte.MinValue}");
        Console.WriteLine($"Максимальное: {byte.MaxValue}");

        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Минимальное и максимальное значение для типа short:");
        Console.WriteLine($"Минимальное: {short.MinValue}");
        Console.WriteLine($"Максимальное: {short.MaxValue}");

        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Минимальное и максимальное значение для типа ushort:");
        Console.WriteLine($"Минимальное: {ushort.MinValue}");
        Console.WriteLine($"Максимальное: {ushort.MaxValue}");

        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Минимальное и максимальное значение для типа int:");
        Console.WriteLine($"Минимальное: {int.MinValue}");
        Console.WriteLine($"Максимальное: {int.MaxValue}");

        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Минимальное и максимальное значение для типа uint:");
        Console.WriteLine($"Минимальное: {uint.MinValue}");
        Console.WriteLine($"Максимальное: {uint.MaxValue}");

        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Минимальное и максимальное значение для типа long:");
        Console.WriteLine($"Минимальное: {long.MinValue}");
        Console.WriteLine($"Максимальное: {long.MaxValue}");

        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Минимальное и максимальное значение для типа ulong:");
        Console.WriteLine($"Минимальное: {ulong.MinValue}");
        Console.WriteLine($"Максимальное: {ulong.MaxValue}");

        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Минимальное и максимальное значение для типа float:");
        Console.WriteLine($"Минимальное: {float.MinValue}");
        Console.WriteLine($"Максимальное: {float.MaxValue}");

        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Минимальное и максимальное значение для типа double:");
        Console.WriteLine($"Минимальное: {double.MinValue}");
        Console.WriteLine($"Максимальное: {double.MaxValue}");

        Console.WriteLine("------------------------------------------");

        Console.WriteLine("Минимальное и максимальное значение для типа decimal:");
        Console.WriteLine($"Минимальное: {decimal.MinValue}");
        Console.WriteLine($"Максимальное: {decimal.MaxValue}");

        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Введите длины двух сторон прямоугольника:");

        Console.Write("Сторона A: ");
        double sideA = double.Parse(Console.ReadLine());

        Console.Write("Сторона B: ");
        double sideB = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(sideA, sideB);

        Console.WriteLine("Площадь: " + rectangle.Area);
        Console.WriteLine("Периметр: " + rectangle.Perimeter);
        Console.WriteLine("\n\nЗадание #3\n");
        Console.WriteLine("Точки (0, 0) (3, 0) (3, 3) (0, 3) ");
        Figure figure = new Figure(new Point(0, 0), new Point(3, 0), new Point(3, 3), new Point(0, 3));
        }
    }
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA;
            side2 = sideB;
        }

        private double CalculateArea()
        {
            return side1 * side2;
        }

        private double CalculatePerimeter()
        {
            return 2 * (side1 + side2);
        }

        public double Area
        {
            get { return CalculateArea(); }
        }

        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }
    }

    public class Point
    {
        private double x, y;

        public Point(double x1, double y1)
        {
            x = x1;
            y = y1;
        }
        public double X => x;
        public double Y => y;

    }

    public class Figure
    {

        List<Point> Points = new List<Point>();
        public double P { get; set; }
        public Figure(params Point[] points) 
        {
            Points.AddRange(points);
            PerimeterCalculator();
        }

        private static double LengthSide(Point A, Point B) =>
            Math.Sqrt(Math.Pow(Math.Abs(A.X - B.X), 2) + Math.Pow(Math.Abs(A.Y - B.Y), 2));
    
        private void PerimeterCalculator()
        {
            string name = "";
            for (int i = 0; i < Points.Count; i++)
            {
                if (i == Points.Count - 1)
                {
                    P += LengthSide(Points[0], Points[i]);
                    break;
                }
                P += LengthSide(Points[i], Points[i + 1]);
            
            }
            if (Points.Count == 3)
            { name = "Треугольника"; } 
            else if (Points.Count == 4) 
            { name = "Четырехугольника"; }
            else if (Points.Count == 5)
            { name = "Пятиугольника"; }

            Console.WriteLine("Периметр {0} =  {1} ", name ,P);
        }
    }


}

        
        
    

    


