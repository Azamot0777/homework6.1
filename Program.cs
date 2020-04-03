using System;

namespace Homework6
{


    class Rectangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }

        public double Area { get; }

        public double Perimetr { get; }

        public void AreaCalculator(double)
        {

        }

        public void PerimetrCalculator(double)
        {

        }



    }


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle s = new Rectangle();
            s.side1 = double.Parse(Console.ReadLine());
            s.side2 = double.Parse(Console.ReadLine());
        }
    }
}
