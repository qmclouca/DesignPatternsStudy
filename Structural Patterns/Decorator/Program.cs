using System;
namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro("Gamma, Helm, Johnson, and Vlissides", "Design Patterns", 2);
            livro.Exibe();

            Video video = new Video("Rodolfo", "Nasa Space Apps", 120, 2);
            video.Exibe();

            Console.WriteLine("\nEmprestando o livro...");
            Emprestado emprestado = new Emprestado(livro);

            emprestado.EmprestaItem("Rodolfo");
            emprestado.EmprestaItem("Patrícia");

            emprestado.Exibe();
            Console.WriteLine("\nDevolvendo o livro...");
            emprestado.DevolveItem("Rodolfo");
            emprestado.Exibe();
            Console.ReadKey();
        }
    }
}