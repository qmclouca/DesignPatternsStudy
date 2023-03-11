namespace Bridge
{
    internal class Culinaria: ICanal
    {
        const string canal = "Canal de culinária.";
        public string Canal()
        {
            return string.Format("Sintonizado no: {0}", canal);
        }

        public string Status()
        {
            return string.Format("Assistindo: {0}", canal);        
        }
    }
}
