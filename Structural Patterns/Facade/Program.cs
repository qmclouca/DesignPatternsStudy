namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.MetodoA();
            facade.MetodoB();

            Console.ReadKey();         
        }
    }
}