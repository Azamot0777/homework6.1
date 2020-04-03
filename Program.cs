using System;

namespace Homework6
{


    class Rectangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle s = new Rectangle();
            s.side1 = 2.4;
            s.side2 = 5.7;
        }
    }
}
