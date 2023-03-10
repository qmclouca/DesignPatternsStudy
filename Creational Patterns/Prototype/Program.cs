namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioPermanente funcionarioPermanente = new FuncionarioPermanente();
            funcionarioPermanente.Nome = "João";
            funcionarioPermanente.Idade = 30;
            funcionarioPermanente.Tipo = "Permanente";

            FuncionarioPermanente funcionarioPermanenteClonado = (FuncionarioPermanente)funcionarioPermanente.Clone();
            funcionarioPermanenteClonado.Nome = "Marcelo";
            funcionarioPermanenteClonado.Idade = 43;
            funcionarioPermanenteClonado.Tipo = "Contrato 20 dias";

            Console.WriteLine("Detalhes do Funcionário Permanente: ");
            Console.WriteLine("Nome: {0}; Idade: {1}; Tipo: {2}", funcionarioPermanente.Nome, funcionarioPermanente.Idade, funcionarioPermanente.Tipo);
            Console.WriteLine("Detalhes do Funcionário Permanente Clonado: ");
            Console.WriteLine("Nome: {0}; Idade: {1}; Tipo: {2}", funcionarioPermanenteClonado.Nome, funcionarioPermanenteClonado.Idade, funcionarioPermanenteClonado.Tipo);

            Console.ReadKey();
        }
    }
}