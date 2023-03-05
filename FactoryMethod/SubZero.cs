using System;

namespace FactoryMethod
{
    public class SubZero : ICharacter
    {
        public void SelectedCharacter()
        {
            Console.WriteLine("SubZero foi escolhido");
        }
    }
}