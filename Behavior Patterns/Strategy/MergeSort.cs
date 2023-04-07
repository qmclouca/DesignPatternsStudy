namespace Strategy
{
    public class MergeSort: SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); // Default is ascending.
            System.Console.WriteLine("MergeSorted list ");
        }
    }
}
