namespace State
{
    public class Context
    {
        private State _state;
        public Context(State state)
        {
            this.State = state;
        }
        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                System.Console.WriteLine("State: " + _state.GetType().Name);
            }
        }
        public void Request()
        {
            _state.Handle(this);
        }
    }
}
