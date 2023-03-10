namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = ExecuteAbstractFactory.assemblyCar("Luxury");
            Car car2 = ExecuteAbstractFactory.assemblyCar("Cheap");

            Console.ReadKey();
        }

    }
}