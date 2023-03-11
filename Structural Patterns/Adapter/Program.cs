namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TanqueInimigo rx2018 = new TanqueInimigo();
            RoboInimigo R2D2 = new RoboInimigo();

            IAtaqueInimigo roboAdapter = new RoboInimigoAdapter(R2D2);

            Console.WriteLine("======== Robô =========");
            R2D2.ReagirContraHumano("Paulo");
            R2D2.AndarFrente();
            R2D2.EsmagarComMaos();

            Console.WriteLine("======== Tanque =========");
            rx2018.Pilotar("João");
            rx2018.Movimenta();
            rx2018.ArmaFogo();

            Console.WriteLine("======== Robô Adaptado =========");
            roboAdapter.Pilotar("Maria");
            roboAdapter.Movimenta();
            roboAdapter.ArmaFogo();

            Console.ReadKey();
        }
    }    
}