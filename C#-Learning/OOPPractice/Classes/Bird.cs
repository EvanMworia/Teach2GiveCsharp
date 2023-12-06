namespace OOPPractice.Classes
{
    internal class Bird
    {

        private string secret=" I can Talk";

        public string Name { get; set; }
       
       public string ShowSecret
        {
            get { return secret; }
            set
            {
                if (value.ToLower().Contains("I Can"))
                {
                    secret = value;
                }
                else
                {
                    return;
                }
            }
        }

        public string ShowSecret1
        {
            get=> secret;
            set {
        //logic here
            }
        }


        public string ShowSecret2 { get; set; }
        private int showAge()
        {
            return 2;
        }

        public void printAge()
        {
         
            Console.WriteLine(this.showAge());
        }

        public int Age { get => this.showAge(); }



    }
}
