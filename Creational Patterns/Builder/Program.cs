namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabricante fabricante = new Fabricante();
            ICelular celularBuilder = null;

            celularBuilder = new IphoneBuilder();
            fabricante.Construir(celularBuilder);
            Console.WriteLine("Um novo celular foi construído: \n\n{0}", celularBuilder.Celular.Nome);
            Console.ReadKey();
        }
    }
}   