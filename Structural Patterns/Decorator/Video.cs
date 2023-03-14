using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Video: ItemBiblioteca
    {
        private string director;
        private string titulo;
        private int duracao;

        public Video(string director, string titulo, int duracao, int numeroCopias)
        {
            this.director = director;
            this.titulo = titulo;
            this.duracao = duracao;
            this.numeroCopias = numeroCopias;
        }

        public override void Exibe()
        {
            Console.WriteLine("\nVideo ------ ");
            Console.WriteLine(" Titulo: {0}", titulo);
            Console.WriteLine(" Director: {0}", director);
            Console.WriteLine(" Duracao: {0}", duracao);
            Console.WriteLine(" # Copias: {0}", numeroCopias);
        }   
    }
}
