namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            var list = new List<AbstractExpression>();
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());
            foreach (var item in list)
            {
                item.Interpret(context);
            }
        }
    }   
}