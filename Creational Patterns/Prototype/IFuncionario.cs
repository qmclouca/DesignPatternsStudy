namespace Prototype
{
    public interface IFuncionario
    {
        IFuncionario Clone();
        string Nome { get; set; }
        string Tipo { get; set; }
        int Idade { get; set; }        
    }
}
