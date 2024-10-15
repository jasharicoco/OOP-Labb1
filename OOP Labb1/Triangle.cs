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

        public void GetArea()
        {
            Console.WriteLine($"Arean av en triangel med basen {Base} cm och höjden {Height} cm är: {(Base * Height) / 2}");
        }
    }
}
