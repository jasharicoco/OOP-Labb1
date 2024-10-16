using System;

namespace OOP_Labb1
{
    internal class Circle
    {
        private float _pi = 3.141f;
        private int _Radius;

        public Circle(int radius)
        {
            _Radius = radius;
        }

        public void GetArea()
        {
            Console.WriteLine($"Arean av en cirkel med radie {_Radius} cm är: {_pi * _Radius * _Radius} cm²");
        }

        public void GetVolume()
        {
            Console.WriteLine($"Volymen av en sfär med radie {_Radius} cm är: {_Radius * _Radius * _Radius * 4 / 3 * _pi} cm³");
        }





        /* Hur hade proffsen gjort?
         
        public float GetArea()
        {
            return _Radius * _Radius * _pi;
        }
        
        sedan
        Console.WriteLine($"Arean av en cirkel med radie 5 är: {circle1.GetArea()}");
        i main-metoden

        ELLER

        public void GetArea()
        {
            Console.WriteLine($"Arean av en cirkel med radie {_Radius} cm är: {_pi * _Radius * _Radius} cm²");
        }

        sedan
        circle1.GetArea();
        i main-metoden
        
        */
    }
}