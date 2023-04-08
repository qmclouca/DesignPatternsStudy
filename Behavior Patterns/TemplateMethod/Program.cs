namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass[] classes = new AbstractClass[2];
            classes[0] = new ConcreteClassA();
            classes[1] = new ConcreteClassB();
            foreach (AbstractClass c in classes)
            {
                c.TemplateMethod();
            }
        }
    }
}