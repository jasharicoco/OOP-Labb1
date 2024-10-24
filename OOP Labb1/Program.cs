namespace OOP_Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa cirklar med olika radie
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            Console.WriteLine($"Arean av en cirkel med radie {circle1._Radius} är: {circle1.GetArea()} cm²");
            Console.WriteLine($"Arean av en cirkel med radie {circle1._Radius} är: {circle1.GetVolume()} cm³");
            Console.WriteLine("");
            Console.WriteLine($"Arean av en cirkel med radie {circle2._Radius} är: {circle2.GetArea()} cm²");
            Console.WriteLine($"Arean av en cirkel med radie {circle2._Radius} är: {circle2.GetVolume()} cm³");

            //Skapa trianglar med olika baser och höjder
            Triangle triangle1 = new Triangle(2, 5);
            Triangle triangle2 = new Triangle(4, 10);

            Console.WriteLine("");
            Console.WriteLine($"Arean av en triangel med basen {triangle1.Base} cm och höjden {triangle1.Height} cm är: {triangle1.GetArea()} cm²");
            Console.WriteLine($"Arean av en triangel med basen {triangle2.Base} cm och höjden {triangle2.Height} cm är: {triangle2.GetArea()} cm²");
        }
    }
}
