namespace Memento
{
    public class Memento
    {
        private string _state;
        public Memento(string state)
        {
            _state = state;
        }
        public string State
        {
            get { return _state; }            
        }
    }
}
