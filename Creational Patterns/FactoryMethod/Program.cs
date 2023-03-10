using System;
namespace FactoryMethod
{
    public class Program
    {
        public static void Main()
        {            
            FactoryMethod fm = new FactoryMethod();
            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine();
            Console.WriteLine("Select your character");
            
            string caracter = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You will play with: ");
            fm.SelectCharacter(caracter)?.SelectedCharacter();
            Console.ReadKey();
        }
    }
}
