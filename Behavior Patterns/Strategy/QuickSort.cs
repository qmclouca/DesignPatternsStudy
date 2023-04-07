namespace Strategy
{
    public class QuickSort: SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            System.Console.WriteLine("QuickSorted list ");
        }
    }
}
