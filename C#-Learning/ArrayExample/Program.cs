// array is a fixed collection that stores element of the same type.

int[] numbers = new int[4] { 1,2,3,4};//declare & initialize


int[] numbers1 = new int[4];//declare
numbers1[0]=2; //initialize
numbers1[1]=3;

Console.WriteLine(numbers1[3]);

//index 2 and 3 are going to have default (0)

int[] numbers2 = {1,2,3,4};

//indexing  
Console.WriteLine(numbers2[2]);

// iterations - foreach - For loops

//foreach
//we get the values


numbers2[0] = 100;
Array.Clear(numbers2);
//for Loop
// we can get both the index and the value
for (int i = 0; i < numbers2.Length; i++)
{
    numbers2[i] += 100;
    //Console.WriteLine($"{i} = {numbers2[i]}");
}
foreach (int i in numbers2)
{
    Console.WriteLine(i);
}

//readonly-cannot be updated/modified

numbers2[0] = 100;
var numberreadonly = Array.AsReadOnly(numbers2);
//numberreadonly[1] = 100;


// Downside 

//The array size is fixed- over/under utilization of memory
//It is also not possible to insert or remove elements from
//the middle of an array