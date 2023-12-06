
using generic;

CompareTypes comp = new();


Console.WriteLine(comp.compare<int>(10, 10));
Console.WriteLine(comp.compare<int>(10, 130));
Console.WriteLine(comp.compare<double>(12.34, 130.34));
Console.WriteLine(comp.compare<string>("evans", "evans"));
