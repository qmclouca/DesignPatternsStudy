namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("FlyWeight");
            Console.WriteLine();
            FabricaFlyWeight tartarugaFactory = new FabricaFlyWeight();
            Tartaruga tartaruga1 = tartarugaFactory.GetTartaruga("vermelha");

        }
    }
}