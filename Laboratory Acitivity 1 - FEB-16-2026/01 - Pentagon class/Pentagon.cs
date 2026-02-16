using System;

namespace PentagonApp
{ 
    class Pentagon
    {
        private double side;
        public Pentagon()
        {
            side = 0;
        }
        public Pentagon(double sideLength)
        {
            side = sideLength;
        }
        public double GetPerimeter()
        {
            return 5 * side;
        }
        public double GetArea()
        {
            return (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * side * side) / 4;
        }
    
        public void display()
        {
            Console.WriteLine($"Side Length: {side}");
            Console.WriteLine($"Perimeter: {GetPerimeter():F3}");
            Console.WriteLine($"Area: {GetArea():F3}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pentagon p1 = new Pentagon();
            Console.WriteLine("Pentagon p1");
            Console.WriteLine("-------------------------");
            p1.display();

            Console.WriteLine();

            Pentagon p2 = new Pentagon(5);
            Console.WriteLine("Pentagon p2");
            Console.WriteLine("-------------------------");
            p2.display();
        }
    }
}
