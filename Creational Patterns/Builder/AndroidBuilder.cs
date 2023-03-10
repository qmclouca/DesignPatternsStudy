namespace Builder
{
    public class AndroidBuilder : ICelular
    {
        Celular celular;
        public Celular Celular
        {
            get { return this.celular; }
        }

        public AndroidBuilder() 
        {
            this.celular = new Celular("Android");
        }

        public void BuildBateria()
        {
            this.celular.bateria = "5000 mAh";
        }

        public void BuildCamera()
        {
            this.celular.camera = "12 MP";
        }

        public void BuildSistema()
        {
            this.celular.Sistema = "Android 10";
        }

        public void BuildTela()
        {
            this.celular.tela = "6.5\"";
        }
    }    
}