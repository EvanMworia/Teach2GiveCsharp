
using System.Collections;
// arrayList is a dynamic collection that stores element of different types.

ArrayList arrayList = new ArrayList()
{
   "Maxon",
    23,
    true,
    null
};//declare and initialize items


ArrayList arrayList1 = new ArrayList();

//adding items
arrayList1.Add(1);//int =>object
arrayList1.Add(2);
arrayList1.Add(3);
arrayList1.Add(4);
arrayList1.Add(4);
arrayList1.Add("Hello");
arrayList1.Add(true);


//Access by index
var value2 = (int) arrayList1[2];
Console.WriteLine($"integer{value2}");

//FOreach- has value

foreach (var item in arrayList1)
{
    Console.WriteLine(item);
}

//Forloop-- has index/values

for (int i = 0; i < arrayList1.Count; i++)
{
    Console.WriteLine($"{i}= {arrayList1[i]}");
}

// Insert 
arrayList1.Insert(2, 1000);
arrayList1.InsertRange(1, arrayList);

//for (int i = 0; i < arrayList1.Count; i++)
//{
//    Console.WriteLine($"{i}= {arrayList1[i]}");
//}

//removing 
//Remove- Single item (dont know index , just know the item)
//RemoveAt-remove based on index
//removeRange- several items

arrayList1.Remove("Maxon");
arrayList1.RemoveAt(1);
arrayList1.RemoveRange(0, 3);



for (int i = 0; i < arrayList1.Count; i++)
{
    Console.WriteLine($"{i}= {arrayList1[i]}");
}

Console.WriteLine(arrayList1.Contains("Maxon"));