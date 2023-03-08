namespace Builder
{
    public class IphoneBuilder : ICelular
    {
        Celular celular;

        public IphoneBuilder() 
        {
            celular = new Celular("Iphone");
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
            this.celular.Sistema = "iOS";
        }

        public void BuildTela()
        {
            this.celular.tela = "9\"";
        }

        public Celular Celular
        {
            get { return this.celular; }
        }
    }    
}