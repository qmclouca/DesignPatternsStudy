namespace FlyWeight
{
    public class FabricaFlyWeight
    {
        private static readonly Dictionary<string, Tartaruga> Tartarugas = new Dictionary<string, Tartaruga>();
        public static Tartaruga GetTartaruga(string cor)
        {
            Tartaruga tartaruga = null;
            if (Tartarugas.ContainsKey(cor))
            {
                tartaruga = Tartarugas[cor];
            }
            else
            {
                switch (cor)
                {
                    case "verde":
                        Console.WriteLine("Criando tartaruga verde");
                        tartaruga = new Verde();
                        break;
                    case "laranja":
                        Console.WriteLine("Criando tartaruga laranja");
                        tartaruga = new Laranja();
                        break;
                    case "azul":
                        Console.WriteLine("Criando tartaruga azul");
                        tartaruga = new Azul();
                        break;
                    case "vermelha":
                        Console.WriteLine("Criando tartaruga vermelha");
                        tartaruga = new Vermelha();
                        break;
                }
                Tartarugas.Add(cor, tartaruga);
            }
            return tartaruga;
        }
    }
}
