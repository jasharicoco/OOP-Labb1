using System;

namespace OOP_Labb1
{
    internal class Circle
    {
        public int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
            float pi = 3.141f;
        }

        public void GetArea()
        {
            Console.WriteLine($"Arean av en cirkel med radie {Radius} cm är: {Math.PI * Radius * Radius} cm²");
        }

        public void GetVolume()
        {
            Console.WriteLine($"Volymen av en sfär med radie {Radius} cm är: {Math.PI * Radius * Radius * Radius * 4 / 3} cm³");
        }
    }
}