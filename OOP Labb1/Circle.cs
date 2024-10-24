using System;

namespace OOP_Labb1
{
    internal class Circle
    {
        internal float _pi = 3.141f;
        internal int _Radius;

        public Circle(int radius)
        {
            _Radius = radius;
        }

        public float GetArea()
        {
            return _Radius * _Radius * _pi;
        }

        public float GetVolume()
        {
            return _Radius * _Radius * _Radius * 4 / 3 * _pi;
        }

    }
}