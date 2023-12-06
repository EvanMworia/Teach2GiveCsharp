using System.Diagnostics;
using System.Text;

namespace Datatpes.StringExamples
{
    public  class StringClass
    {

        public void stringPractice()
        {
            //Quoted string Literal- escape characters whenever we want to use quotes in quotes
            var message = " The coach said \n \t\"We played Well\" ";
            //problem is multi-line statements 

            //Verbatim string literal
            //uses @ sign 
            //an opening/closing quotes
            // has bad formating
            var message1 = @"
                 i'm able to write
            Multiline Statements 
              and i can keep going
            ""We played Well""

            ";

            //Problem -JSON- messy
            var message3 = @"
                {
                ""postId"": 1,
                ""id"": 1,
                ""name"": ""id labore ex et quam laborum"",
                ""email"": ""Eliseo@gardner.biz"",
                ""body"": ""laudantium enim quasi est quidem magnam voluptate ipsam eos\ntempora quo necessitatibus\ndolor quam autem quasi\nreiciendis et nam sapiente accusantium""
                },
                ";


            //Raw string literal
            //atlest 3 opening/closing quotes
            //does not support outdenting
            var message4 = """"
                Hello there
                hgedvhj
                gdh
                hvfsdh
            

                """";

            var message5 = """
                {
                "postId": 1,
                "id": 1,
                "name": "id labore ex et quam laborum",
                "email": "Eliseo@gardner.biz",
                "body": "laudantium enim quasi est quidem magnam voluptate ipsam eos\ntempora quo necessitatibus\ndolor quam autem quasi\nreiciendis et nam sapiente accusantium"
                }
                """;

            // string interpolation
            //you are referring to a variable in the string
            var greetings = "Hello There";

            Console.WriteLine($"The coach said {greetings} ");

            //Verbatim string interpolation
            var message7 = @$" The coach said the following
                {greetings}
                ""Im happy about the performance ""

            ";

            Console.WriteLine(message7);


            //Raw string interpolation
            var message8 = $""""
               
                The coach said the following
                {greetings}

                """";
            //Raw string interpolation -JSON

            var message9 = $$$"""
                {
                "postId": 1,
                "id": 1,
                "greeting":{{{greetings}}}
                "name": "id labore ex et quam laborum",
                "email": "Eliseo@gardner.biz",
                "body": "laudantium enim quasi est quidem magnam voluptate ipsam eos\ntempora quo necessitatibus\ndolor quam autem quasi\nreiciendis et nam sapiente accusantium"
                }
                """;
        }

        public void immutabilityPractice()
        {
            var str1 = "      ";

            StringBuilder sb = new StringBuilder();
            string text = "   Hello world  ";
            int num1 = 0;
            Stopwatch watch = new Stopwatch();
            watch.Start();

            for(int i=1; i<=100000; i++)
            {
                //sb.Append(i.ToString());

                num1 += i;
                //Console.WriteLine(i);
            }
            watch.Stop();
            Console.WriteLine("It took"+watch.ElapsedMilliseconds);
        }
    }
}
