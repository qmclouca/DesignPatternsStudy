namespace AbstractFactory
{
    public class CheapCarFactory: CarFactory
    {
        public override Tire assemblyTire()
        {
            return new SimpleTire();
        }
        public override Sound assemblySound()
        {
            return new SimpleSound();
        }
    }
}
