namespace OOP_Labb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa en cirkel med radie 5 cm
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(10);

            circle1.GetArea();
            circle1.GetVolume();
            circle2.GetArea();
            circle2.GetVolume();
        }
    }
}
