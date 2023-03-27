namespace FlyWeight
{
    public abstract class Tartaruga
    {
        protected string condicao; //característica intrínseca
        protected string acao; //característica intrínseca
        public string cor { get; set; } //característica extrínseca

        public abstract void Mostra(string cor);

    }
}
