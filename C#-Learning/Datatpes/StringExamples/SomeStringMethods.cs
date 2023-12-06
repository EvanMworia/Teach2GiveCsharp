

namespace Datatpes.StringExamples
{
    public class SomeStringMethods
    {

        public void stringMethodPractice()
        {
            //'toUpper' changes text to UpperCase
            var greetings = "Hello World";
            var result = greetings.ToUpper();
            Console.WriteLine(result);
            Console.WriteLine();//just empty line

            // 'toLower'  changes text to LowerCase
            //let's change the sentense we capitalized above
            var lowercase = result.ToLower();
            Console.WriteLine(lowercase);
            Console.WriteLine();


            // 'trim ' this method removes whitespaces at the beginning and
            // the end of the the word/sentense

            var str2 = "    hello World   ";
            Console.WriteLine($"Before Trimming :{str2}");
            Console.WriteLine($"After Trimming: {str2.Trim()} ");
            Console.WriteLine();

            //searching Indexof()- returns the starting index of the character/substring
            var str3 = "Hello Word";
            Console.WriteLine(str3.IndexOf("llo"));// returns 2 coz "llo" starts from index 2
            Console.WriteLine(str3.IndexOf("W"));//returns 6 coz W is at index 6

            //LastIndexOf() return the index of where the character last appears

            var str4 = "Hello world";
            Console.WriteLine(str4.LastIndexOf("l"));//the last l is at index 9
            Console.WriteLine(str4.LastIndexOf("wor")); //the las wor is at index 6


            //..Substring- returns a part of the string

            var description = @"HP 15 laptop is a fine blend of user-friendly
            configuration, powerful features and a compact design. Featuring 
            stunning visuals and powerful performance, this ultra-versatile
            and light 15.6- inch notebook is an upgrade on style and productivity that
            will meet all your computing needs without putting a dent in your
            wallet. The HP 15 comes in a compact size which makes it
            convenient to take home from work or for that business 
            presentation.";

            Console.WriteLine(description.Substring(20));//cuts first 20 and returns the rest
            Console.WriteLine(description.Substring(0, 20) + "...");//picks first 20


            //replace - replaces the first occuring character/word with the text specified


            var str5 = "Hello World";
            var str6 = str5.Replace("World", "Dotnet");
            Console.WriteLine(str6);


            //null Checking with IsNullorEmpty

            var str7 = " ";
            var str8 = "Hello world";
            Console.WriteLine(string.IsNullOrEmpty(str7));//false- yet its empty
            Console.WriteLine(string.IsNullOrEmpty(str8));//false

            //we can use one that also checks white spaces -IsNullOrWhiteSpace
            Console.WriteLine(string.IsNullOrWhiteSpace(str7));//false- yet its empty
            Console.WriteLine(string.IsNullOrWhiteSpace(str8));//false
            //split- returns an array ans splits using a separator e.g. a comma 
            //for the below example

            var names = "John, Milka, Milla , Susan";
            var mynames = names.Split(',');
            Console.WriteLine(mynames[0]);

            //formating with ToString()

            int i  = 1234;
            Console.WriteLine(i.ToString("C"));
            Console.WriteLine(i.ToString("C0"));
        }
    }
}
