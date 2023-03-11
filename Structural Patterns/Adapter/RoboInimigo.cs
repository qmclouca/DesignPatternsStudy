namespace Adapter
{
    //Objeto a ser adaptado (Adaptee)
    public class RoboInimigo
    {
        Random gerador = new Random();

        public void EsmagarComMaos()
        {
            int danoAtaque = gerador.Next(10) + 1;
            Console.WriteLine("O robô inimigo causou " + danoAtaque + "de dano com o ataque Esmagar com as Mãos.");
        }

        public void AndarFrente()
        {
            int movimento = gerador.Next(10) + 1;
            Console.WriteLine("O Robô inimigo andou " + movimento + "passos para frente.");
        }

        public void ReagirContraHumano(string piloto)
        {
            Console.WriteLine("O Robô Inimigo atacou " + piloto);
        }
    }
}
