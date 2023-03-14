namespace Decorator
{
    public class Emprestado: Decorator
    {
        protected string[] nomesEmprestados = new string[10];
        protected int numeroEmprestados = 0;

        public Emprestado(ItemBiblioteca itemBiblioteca): base(itemBiblioteca)
        {
        }

        public void EmprestaItem(string nome)
        {
            nomesEmprestados[numeroEmprestados] = nome;
            numeroEmprestados++;
        }

        public void DevolveItem(string nome)
        {
            for (int i = 0; i < numeroEmprestados; i++)
            {
                if (nomesEmprestados[i] == nome)
                {
                    for (int j = i; j < numeroEmprestados; j++)
                    {
                        nomesEmprestados[j] = nomesEmprestados[j + 1];
                    }
                    numeroEmprestados--;
                }
            }
        }

        public override void Exibe()
        {
            base.Exibe();

            for (int i = 0; i < numeroEmprestados; i++)
            {
                Console.WriteLine(" Emprestado para: {0}", nomesEmprestados[i]);
            }
        }
    }
}
