using System;

namespace FactoryMethod
{
    public class Scorpion : ICharacter
    {
        public void SelectedCharacter()
        {
            Console.WriteLine("Scorpion foi escolhido");
        }
    }
}