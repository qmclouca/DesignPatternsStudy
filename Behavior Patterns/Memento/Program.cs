namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";
            
            CareTaker c = new CareTaker();
            c.Memento = o.CreateMemento();
            o.State = "Off";
            o.SetMemento(c.Memento); 
            
            Console.ReadKey();
        }
    }
}