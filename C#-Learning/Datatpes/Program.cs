
using Datatpes.Numeric;
using Datatpes.StringExamples;
using Datatpes.TypeConversion;

var numbers = new NumericClass();
//numbers.learningNumbers();//numbers
//numbers.learningRealNumbers();
//numbers.learningChar();

var conversion= new TypeConvertClass();
//conversion.explicitConversion();
//conversion.nonCompatibleTypes();

//Value types 

int a = 10;
int b = a;
b++;

//Console.WriteLine(a);
//Console.WriteLine(b);

//reference Types

int[] array1 =  { 1, 2, 3, 4, 5, 6 };
var array2 = array1 as int[];

array2[0] = 100;

//Console.WriteLine(array2[0]);
//Console.WriteLine(array1[0]);



String[] cars = new String[3];
cars[0] = "Camero";
cars[1] = "Corvette";
cars[2] = "Tesla";

//Console.WriteLine();

string name = "John Doe";
string name1 = name;
name1 = "Jane Doe";
//Console.WriteLine(name);
//Console.WriteLine(name1);


//var str = new StringClass();
//str.stringPractice();
//str.immutabilityPractice();

var str= new SomeStringMethods();
str.stringMethodPractice();
