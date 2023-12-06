

namespace lists.ListExamples
{
    public class ListPractice2
    {

        public void practiceList()
        {
            

            Employee emp = new Employee() {
                Id = 1, 
                Name="Samuel",
                Salary=170000};

            Employee emp1 = new Employee()
            {
                Id = 2,
                Name = "John",
                Salary = 1000000
            };

            Employee emp2 = new Employee()
            {
                Id = 3,
                Name = "John",
                Salary =100000
            };

            Employee emp3 = new Employee()
            {
                Id = 4,
                Name = "Nancy ",
                Salary =2000000
            };

            Employee emp5 = new Employee()
            {
                Id = 5,
                Name = "Zipeta ",
                Salary = 5000000
            };
            Employee emp4 = new Employee()
            {
                Id = 5,
                Name = "Jane Doe ",
                Salary = 500000
            };

            List<Employee> employees = new List<Employee>()
            {emp,emp1,emp2,emp3,emp4,emp5 };

            Employee john = employees.Find(e => e.Name.ToLower() == "john");

            Console.WriteLine(john.Salary);

            Employee john2 = employees.FindLast(e => e.Name.ToLower() == "john");

            Console.WriteLine(john2.Salary);

            List<Employee> rich = employees.FindAll(x => x.Salary>=1000000);


            //sorting 
            //LINQ
            //employees=employees.OrderBy(x=>x.Name).ToList();
            //employees.Sort();

            SortingClass sort = new SortingClass();
            employees.Sort(sort);

            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee.Name);
            }


         

            int index = employees.FindLastIndex(x => x.Name.ToLower().Contains("jane"));
            employees.RemoveAt(index);

            //Console.WriteLine(employees.Count);
            //Console.WriteLine(employees.Exists(x=>x.Name.ToLower().Trim()=="zipeta"));
            //Console.WriteLine(employees.Contains(emp2));
        }
    }
}
