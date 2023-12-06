
namespace OOPPractice.Teach2Give
{
    abstract internal class Employee
    {
        private int salary { get; set; }
        private string name { get; set; }

        //private its only available in the class its defined in 
        protected static string QuoteofTheday = "Be the Best"; 

        public Employee()
        {
            
        }
        public Employee(string name)
        {
            this.name = name;
        }
        public void companyNews()
        {
            Console.WriteLine(" We are going to have an holiday on saturday");
        }

        public void printDetails()
        {
            Console.WriteLine($"The employee is {this.name}");
        }

        public void showTodaysQuote()
        {
            Console.WriteLine(Employee.QuoteofTheday);
        }


        public virtual void showWorking (string wHours="I work from 9-5")
        {
            Console.WriteLine(wHours);
        }




    }

    //is-a relationship // trainer is a  employee //inheritance 
    //has-a relationship // trainer has a Laptop, Address, // composition
    //share code - avoid redundant code 
  
    
}
