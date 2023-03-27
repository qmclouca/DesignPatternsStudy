namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("FlyWeight");
            Console.WriteLine();
            Tartaruga tartaruga1;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Qual tartaruga mostrar?");
                string cor = Console.ReadLine();

                tartaruga1 = FabricaFlyWeight.GetTartaruga(cor);
                tartaruga1.Mostra(cor);
                Console.WriteLine();
                Console.WriteLine("------------------");
            }

        }
    }
}