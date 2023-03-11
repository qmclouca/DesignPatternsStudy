namespace Adapter
{
    //é o adaptador do objeto Robo com Tanque (Adapter)
    public class RoboInimigoAdapter : IAtaqueInimigo
    {
        RoboInimigo roboInimigo; //Passa para o adaptador o objeto a ser adaptado (Adaptee)

        public RoboInimigoAdapter(RoboInimigo novoRobo)
        {
            roboInimigo = novoRobo;
        }

        public void ArmaFogo()
        {
            roboInimigo.EsmagarComMaos();
        }

        public void Movimenta()
        {
            roboInimigo.AndarFrente();
        }

        public void Pilotar(string piloto)
        {
            roboInimigo.ReagirContraHumano(piloto);
        }
    }
}
