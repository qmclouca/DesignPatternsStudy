namespace FlyWeight
{
    internal class Verde: Tartaruga
    {
        public Verde()
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
