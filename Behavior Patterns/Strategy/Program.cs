namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList studentRecords = new SortedList();
            studentRecords.Add("Rodolfo");
            studentRecords.Add("Patrícia");
            studentRecords.Add("Maria");
            studentRecords.Add("Isabel");
            studentRecords.Add("Lucas");
            studentRecords.Add("Ricardo");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            Console.ReadKey();
        }
    }
}
