namespace Facade
{
    public class Facade
    {
        private SubSistema1 um;
        private SubSistema2 dois;
        private SubSistema3 tres;

        public Facade()
        {
            this.um = new SubSistema1();
            this.dois = new SubSistema2();
            this.tres = new SubSistema3();
        }

        public void MetodoA()
        {
            Console.WriteLine("\nMetodoA() ---- ");
            this.dois.Metodo2();
            this.tres.Metodo3();
        }

        public void MetodoB()
        {
            Console.WriteLine("\nMetodoB() ---- ");
            this.um.Metodo1();
            this.tres.Metodo3();
        }        
    }
}
