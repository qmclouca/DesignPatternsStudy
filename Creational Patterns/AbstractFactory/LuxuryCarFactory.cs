namespace AbstractFactory
{
    public class LuxuryCarFactory : CarFactory
    {
        public override Sound assemblySound()
        {
            return new SpecialSound();
        }

        public override Tire assemblyTire()
        {
            return new SpecialTire();
        }
    }
}
