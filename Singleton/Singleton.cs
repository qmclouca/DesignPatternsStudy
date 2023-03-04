namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null) instance = new Singleton();
                return instance;
            }
        }
        public void Message(string msg)
        {
            Console.Write(msg);
        }           
    }
}
