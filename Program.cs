using System;

namespace Homework6
{


    class Rectangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }

        public double Area { get; set; }

        public double Perimetr { get; set; }

        public Init() { }
        public Init(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator(double side1, double side2)
        {
            Area = side1 * side2;
            return Area;
        }

        public double Perimetr(double side1, double side2)
        {
            Perimetr = (side1 + side2) * 2;
            return Perimetr;
        }

        public void GetInfo()
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
