
//manual 

using OOPPractice.AbstractClasses;
using OOPPractice.Bank;
using OOPPractice.Classes;
using OOPPractice.Teach2Give;
using System.Xml.Linq;

//Human jid = new Human();
//jid.Name = "Jidraf";
//jid.Height = 5.7;
//jid.Weight = 60;
//jid.printDetails();

//Console.ReadLine();

//Human zipeta = new Human();
//zipeta.Name = "Zipeta";
//zipeta.Height = 5.1;
//zipeta.Weight = 50;
//zipeta.printDetails();




//new keyword

//before new 
//we have not allocated memory 
// A new object is created {}
//this keyword pointed to the newly created object

//using the constructor

//var david = new Human("David", 12, 5.6, 58);
//david.printDetails();

////using constructor an initializer

//var arthur = new Human("Arthur") { Age = 10,  Weight = 57, Height = 5.7 };

//arthur.printDetails();

//Account ac1= new Account(13);
//Account ac2 = new Account(12);
//ac1.changeRate(4);
//Console.WriteLine(ac1.Tax4);
//ac2.printIntrest();
//ac1.printIntrest();

//ac2.changeRate(5);
//ac2.printIntrest();
//ac1.printIntrest();

//Bird brd= new Bird();
//Console.WriteLine(brd.ShowSecret);
//brd.ShowSecret = "I Will Sing";

////brd.printAge();
//Console.WriteLine(brd.Age);


//Trainer trainer = new("Jonathan Mwaniki");
//trainer.showCurriculums();
//trainer.companyNews();
//trainer.printDetails();

//trainer.changeQuote("I started coding with a semicolon");

//TrainingManager manager = new TrainingManager();
//manager.changeQuote("Swing the Bat");
//manager.showWorking("I work from 11-3");
//trainer.showWorking("I work from 9-5");

//trainer.showTodaysQuote();

Circle c = new();
Square square = new();

List<Shape> shapes = new List<Shape>() { c, square };

foreach (Shape shape in shapes)
{
    shape.Draw();
}
