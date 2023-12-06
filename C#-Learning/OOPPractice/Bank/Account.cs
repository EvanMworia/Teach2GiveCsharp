
namespace OOPPractice.Bank
{
    public class Account
    {
        //accessible via instance --via Class 
        // this is reated only once despite the instances 

        public static int CurrentRate = 9;
        // you must give a value 
        // Its accessible via Class not instance (static -like behaviour)
        //we cant change it
        public const int Tax1 = 16;
        //we must not give a value;
        //we cant change it
        public readonly int Tax = 16;
        //we have not give it a value
        // we must assign it a value  in the constructor
        //we cant change it
        public readonly int Tax2;
        
        //write only property
        // we can write but we cant get
        public int Tax3 { set
            {
                //make sure the value is more than 10
                value = Tax;
            } }
        //readonly 
        public int Tax4
        {
            get { return Tax; }
        }

        public Account(int tax)

        {
            
            this.Tax2 = tax;
        }
        public void changeRate(int rate)
        {
            Account.CurrentRate=rate;
        }

        public void printIntrest()
        {
            Console.WriteLine(Account.CurrentRate);
        }
    }
}
