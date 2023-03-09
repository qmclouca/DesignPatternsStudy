namespace Prototype
{
    internal class FuncionarioTemporario : IFuncionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Tipo { get; set; }

        public IFuncionario Clone()
        {
            return (IFuncionario)MemberwiseClone();
        }
    }
}
