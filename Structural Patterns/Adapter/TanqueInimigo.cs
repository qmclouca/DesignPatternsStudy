namespace Adapter
{
    public class TanqueInimigo: IAtaqueInimigo
    {
        Random gerador = new Random();

        public void ArmaFogo()
        {
            int danoAtaque = gerador.Next(10) + 1;
            Console.WriteLine("O dano do ataque é de " + danoAtaque + " pontos");
        }

        public void Movimenta()
        {
            int movimento = gerador.Next(5) + 1;
            Console.WriteLine("O tanque se moveu " + movimento + " espaços");
        }

        public void Pilotar(string piloto)
        {
            Console.WriteLine(piloto + " está pilotando o tanque");
        }
    }    
}
