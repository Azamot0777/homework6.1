﻿using System;

namespace Homework6
{


    class Rectangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }

        public double area { get; set; }

        public double Perimetr { get; set; }

        public Init() { }
        public Init(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator(double side1, double side2)
        {
            area = side1 * side2;
            return area;
        }

        public double PerimetrCalculator(double side1, double side2)
        {
            Perimetr = (side1 + side2) * 2;
            return Perimetr;
        }

        public double Area { get { return Area; } }
        public double Perimetr {get { return Perimetr; } }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle s = new Rectangle();
            System.Console.WriteLine("Side 1 = ");
            s.side1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Side 2 = ");
            s.side2 = double.Parse(Console.ReadLine());
            s.AreaCalculator(side1, side2);
            System.Console.WriteLine($"Area is {s.Area}");
            s.PerimetrCalculator(side1, side2);
            System.Console.WriteLine($"Perimetr is {s.Perimetr}");
        }
    }
}
