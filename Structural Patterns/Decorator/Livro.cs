using System;
namespace Decorator
{
    internal class Livro: ItemBiblioteca
    {
        private string autor;
        private string titulo;

        public Livro(string autor, string titulo, int numeroCopias)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.numeroCopias = numeroCopias;
        }

        public override void Exibe()
        {
            Console.WriteLine("\nLivro ------ ");
            Console.WriteLine(" Titulo: {0}", titulo);
            Console.WriteLine(" Autor: {0}", autor);
            Console.WriteLine(" # Copias: {0}", numeroCopias);
        }   
    }
}
