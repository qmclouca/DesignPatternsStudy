using System;
namespace FactoryMethod
{
    public class LiuKang : ICharacter
    {
        public void SelectedCharacter()
        {
            Console.WriteLine("Liu Kang foi escolhido!");
        }
    }
}