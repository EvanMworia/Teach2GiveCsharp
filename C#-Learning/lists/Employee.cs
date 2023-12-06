
namespace lists
{   

    //implementing an IComparable interfaces
    internal class Employee:IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int Salary { get; set; }

        public int CompareTo(Employee? other)
        {
            //sorting logic

            if(this.Salary > other.Salary) return -1;
            else if(this.Salary < other.Salary)return 1;
            else return 0;
        }
    }
}
