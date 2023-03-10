namespace Builder
{
    public class Fabricante
    {
        public void Construir(ICelular celular)
        {
            celular.BuildTela();
            celular.BuildBateria();
            celular.BuildSistema();
            celular.BuildCamera();
        }
    }
}
