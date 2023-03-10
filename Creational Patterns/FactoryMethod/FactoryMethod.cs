namespace FactoryMethod
{
    public class FactoryMethod
    {
        public ICharacter SelectCharacter(string caracter)
        {
            return caracter switch
            {
                "Liu Kang" => new LiuKang(),
                "SubZero" => new SubZero(),
                "Scorpion" => new Scorpion(),
                _ => null,
            };
        }
    }
}