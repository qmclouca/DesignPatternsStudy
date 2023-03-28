namespace ChainOfResponsibility
{
    public class ConcreteHandler2 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request > 10  && request <= 20)
            {
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            }
            else if (sucessor != null)
            {
                sucessor.HandlerRequest(request);
            }
        }
    }
}
