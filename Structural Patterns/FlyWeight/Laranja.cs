namespace FlyWeight
{
    internal class Laranja : Tartaruga
    {
        public Laranja()
        {
            condicao = "tartaruga na casca";
            acao = "rodando no chão - ";
        }
        public override void Mostra(string cor)
        {
            this.cor = cor;
            Console.WriteLine(acao + condicao + " " + this.cor);
        }
    }
}