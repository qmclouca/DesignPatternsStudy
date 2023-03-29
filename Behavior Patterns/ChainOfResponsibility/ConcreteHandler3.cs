namespace ChainOfResponsibility
{
    public class ConcreteHandler3 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request > 20  && request <= 30)
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
