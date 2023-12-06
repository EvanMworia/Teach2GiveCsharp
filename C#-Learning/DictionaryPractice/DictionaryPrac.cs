using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractice
{
    internal class DictionaryPrac
    {

        public void DictionaryPractice()
        {

            //declaring/ initializing
            Dictionary<string, string> car = new Dictionary<string, string>()
            {
                {"carName", "BMW" },
                {"12","23" },
                {"age", this.getAge()}
            };

            //this.DictionaryPractice();

            car.Add("Model", "2014");
           

            //Accessing by Key
            Console.WriteLine(car["carName"]);

            //Foreach Loop 
            //foreach(KeyValuePair<string, string> prop in car)
            //{
            //    Console.WriteLine($"{prop.Key}:{prop.Value}");
            //}



            //exists

            Console.WriteLine(car.ContainsKey("carName"));
            Console.WriteLine(car.ContainsValue("ere"));
            Console.WriteLine(car.ContainsValue("2014"));

            //car.Remove("Model");
            //car.Clear();
            //foreach (string key in car.Keys)
            //{
            //    Console.WriteLine($"{key}:{car[key]}");
            //}

            Employee emp = new Employee()
            {
                Id = 1,
                Name = "Samuel",
                Salary = 170000
            };

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
                Salary = 100000
            };

            Employee emp3 = new Employee()
            {
                Id = 4,
                Name = "Nancy ",
                Salary = 2000000
            };

            Employee emp5 = new Employee()
            {
                Id = 5,
                Name = "Zipeta ",
                Salary = 5000000
            };
            Employee emp4 = new Employee()
            {
                Id = 6,
                Name = "Jane Doe ",
                Salary = 500000
            };

            Dictionary<int, Employee> employees = new Dictionary<int, Employee>()
            {
                {emp1.Id,emp1}, {emp2.Id,emp2},{emp3.Id,emp3} , {emp4.Id,emp4}, {emp5.Id, emp5 }
             };
            employees.Add(emp.Id, emp);

            foreach (int key in employees.Keys)
            {
                Console.WriteLine($"{key}:{employees[key].Name},");
            }


        }

        public string getAge()
        {

            //calculations
            return "2";
        }
    }
}
