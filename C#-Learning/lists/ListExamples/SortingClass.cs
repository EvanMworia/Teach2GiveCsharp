
namespace lists.ListExamples
{
    internal class SortingClass : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Name.CompareTo(y.Name);
        }

        public void sayHello()
        {
            Console.WriteLine("Hello There");
        }
    }
}
