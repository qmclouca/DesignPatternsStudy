namespace Observer
{
    public class ConcreteSubject: Subject
    {
        private string subjectState;
        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }
}
