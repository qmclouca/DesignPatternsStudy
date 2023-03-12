namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartTv smartTv = new SmartTv();
            Console.WriteLine("Selecione um canal: ");
            Console.WriteLine("1 - Filmes. \n 2 - Documentários. \n 3 - Culinária. \n");

            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.KeyChar)
            {
                case '1':
                    smartTv.canalAtual = new Filme();
                    break;
                case '2':
                    smartTv.canalAtual = new Documentario();
                    break;
                case '3':
                    smartTv.canalAtual = new Culinaria();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;  
            }
            Console.WriteLine();
            smartTv.ExibeCanalSintonizado();
            smartTv.PlayTv();
            Console.ReadKey();
        }
    }
}