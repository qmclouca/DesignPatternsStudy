namespace FlyWeight
{
    internal class Azul: Tartaruga
    {
        public Azul()
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
