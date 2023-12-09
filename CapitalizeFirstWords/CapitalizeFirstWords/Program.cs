using CapitalizeFirstWords;

TittleCase tc= new();
Console.WriteLine("Give me a text in all lowercase, i will format it for you to tittle case :-)");
string test = Console.ReadLine();
tc.tittleCase(test);
