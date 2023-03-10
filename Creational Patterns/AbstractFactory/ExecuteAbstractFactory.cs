namespace AbstractFactory
{
    public class ExecuteAbstractFactory
    {
        public static Car assemblyCar(string carName)
        {
            CarFactory cf = null;
            switch (carName)
            {
                case "Luxury":
                    cf = new LuxuryCarFactory();
                    break;
                case "Cheap":
                    cf = new CheapCarFactory();
                    break;
            }
            Car car = new Car();
            car.tire = cf.assemblyTire();
            car.sound = cf.assemblySound();
            return car;
        }
    }
}
