using System.Runtime.InteropServices;

namespace Labb5MorganWestinOop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            float area1 = circle1.GetArea();
            float area2 = circle2.GetArea();

            float circumference1 = circle1.GetCircumference();
            float circumference2 = circle2.GetCircumference();

            float volume1 = circle1.GetVolumeAsSphere();
            float volume2 = circle2.GetVolumeAsSphere();

            Console.WriteLine("Area of circle with radius 5: " + area1);
            Console.WriteLine("Area of circle with radius 6: " + area2);

            Console.WriteLine("Circumference of circle with radius 5: " + circumference1);
            Console.WriteLine("Circumference of circle with radius 6: " + circumference2);

            Console.WriteLine("Volume of sphere with radius 5 (as if it were a sphere): " + volume1);
            Console.WriteLine("Volume of sphere with radius 6 (as if it were a sphere): " + volume2);

            Console.ReadLine();
        }   
    }
}