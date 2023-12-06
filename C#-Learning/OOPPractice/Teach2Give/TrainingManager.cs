namespace OOPPractice.Teach2Give
{
    internal class TrainingManager:Employee
    {

        public void GenerateReports()
        {
            Console.WriteLine(" we have 2 cohors on C# and QA/QE");
        }

        public void changeQuote(string quote)
        {
            QuoteofTheday = quote;
        }
        public override void showWorking(string wHours)
        {
            base.showWorking(wHours);
        }
    }
}
