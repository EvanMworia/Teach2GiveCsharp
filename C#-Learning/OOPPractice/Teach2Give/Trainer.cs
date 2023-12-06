
namespace OOPPractice.Teach2Give
{
    internal class Trainer:Employee
    {   

        public Laptop lapi= new Laptop() { Name="Lenovo"};
        public Trainer(string name):base(name)
        {
            
        }
        public void showCurriculums()
        {
            Console.WriteLine("I can tech fullstack C# and Fullstact JS/TS");
        }

        public void changeQuote(string quote)
        {
            QuoteofTheday = quote;
            
        }

        public override sealed void showWorking(string wHours)
        {
            base.showWorking(wHours);
        }

    }
}
