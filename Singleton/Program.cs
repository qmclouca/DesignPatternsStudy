using System;
namespace Singleton
{    class Program
    {
        static void Main(string[] args)
        {
            Singleton player1 = Singleton.GetInstance;
            player1.Message("Jogador 1: A bola está comigo no meio de campo");

            Singleton player2 = Singleton.GetInstance;
            player2.Message("Jogador 2: Recebi a bola");

            Singleton player3 = Singleton.GetInstance;
            player3.Message("Jogador 3: Recebi a bola na linha de fundo");

            Console.ReadKey();
        }
    }   
}