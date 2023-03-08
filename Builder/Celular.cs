namespace Builder
{
    public class Celular
    {
        string nomeCelular;
        public Celular(string nome)
        {
            this.nomeCelular = nome;
        }
        public string Nome { get; set; }
        public ETela tela { get; set; }
        public EBateria bateria { get; set; }
        public ESistemaOperacional Sistema { get; set; }
        public ECamera camera { get; set; }
    }
}
