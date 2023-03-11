namespace Bridge
{
    public class SmartTv
    {
        //Aqui é onde o Bridge é aplicado
        public ICanal? canalAtual { get; set; }
        public void ExibeCanalSintonizado()
        {
            if (canalAtual != null)
                Console.WriteLine(canalAtual.Canal());
            else
                Console.WriteLine("Por favor, selecione o canal.");
        }
        public void PlayTv()
        {
            if (canalAtual != null)
                Console.WriteLine(canalAtual.Status());
            else
                Console.WriteLine("Por favor, selecione um canal.");
        }
    }
}
