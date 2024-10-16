namespace OOP_Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa cirklar med olika radie
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            circle1.GetArea();
            circle1.GetVolume();
            Console.WriteLine("");
            circle2.GetArea();
            circle2.GetVolume();

            //Skapa trianglar med olika baser och höjder
            Triangle triangle1 = new Triangle(2, 5);
            Triangle triangle2 = new Triangle(4, 10);

            Console.WriteLine("");
            triangle1.GetArea();
            triangle2.GetArea();
        }
    }
}
