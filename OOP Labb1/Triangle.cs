namespace OOP_Labb1
{
    internal class Triangle
    {
        public int Base {  get; set; }
        public int Height { get; set; }

        public Triangle(int _base, int height)
        {
            Base = _base;
            Height = height;
        }

        public float GetArea()
        {
            return ((Base * Height) / 2);
        }

    }
}
