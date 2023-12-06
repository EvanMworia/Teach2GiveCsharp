
using System.Xml.Linq;

namespace OOPPractice.Classes
{   

    //Access Modifier
    //internal - anywhere inside this assembly /OOPPractice
    //default is private
    //public - i can access it inthis project and from other projects too (e.g. lists,generics ,files)
    
    // access modifier   class keyword  Name
    public class Human  
    { //methods
        //special method called a constructor
        //fields/ properties
        public string Name { get; set; }
        
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        //
        //constructor overloading
        public Human(): this("", 0, 0 , 0)
        {
            
        }
        public Human(string name): this(name, 0, 0, 0)
        {
            
        }
        public Human(string name, int age):this(name, age, 0,0)
        {
            
        }
        public Human(string name, int age, double h):this(name,age,h,0)
        {
             
        }
        //Master Constructor
        public Human(string name, int age , double h , double w)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = h;
            this.Height = w;
        }
        public void walk()
        {
            Console.WriteLine("Walking...");
        }
        public string Talk()
        {
            return "Talking";
        }
        public void printDetails()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Height);
            Console.WriteLine(Weight);
        }

    }
}
