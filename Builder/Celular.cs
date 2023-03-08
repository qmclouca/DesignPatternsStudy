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
        public string tela { get; set; }
        public string bateria { get; set; }
        public string Sistema { get; set; }
        public string camera { get; set; }
    }
}
