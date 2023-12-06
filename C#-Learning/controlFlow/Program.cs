

var age = 38;
if(age>18 && age < 35)
{
    Console.WriteLine("Youth");
}
else if (age > 18) //if this is true
{
    Console.WriteLine("Legal");
}
else
{
    Console.WriteLine("Illegal");
}


//Switch
var weather = "cloudy";
switch (weather)
{
    case "windy":
        Console.WriteLine("Its a windy day");
        break;

    case "rainy":
        Console.WriteLine("The weather is rainy");
        break;

    case "sunny":
        Console.WriteLine("The weather is sunny");
        return;

    default:
        Console.WriteLine("invalid Value");
        break;
}


//while (true)
//{
//    Console.WriteLine(" Input a number or q to quit");
//    var input = Console.ReadLine();

//    if (input.Equals("q"))
//    {
//        Console.WriteLine("bye");
//        return;
//    }
//    else
//    {
//        var isNumber=int.TryParse(input, out int number);
//        if (isNumber)
//        {
//            //we can send back a square
//            Console.WriteLine($"The square is : {number *number}");
//        }
//        else
//        {
//            Console.WriteLine("Enter a valid number!!");
//        }
//    }

//}


//executed at-least once before the condition is checked
do {
    Console.WriteLine(" Input a number or q to quit");
    var input = Console.ReadLine();

    if (input.Equals("q"))
    {
        Console.WriteLine("bye");
        break;
    }
    else
    {
        var isNumber = int.TryParse(input, out int number);
        if (isNumber)
        {
            //we can send back a square
            Console.WriteLine($"The square is : {number * number}");
        }
        else
        {
            Console.WriteLine("Enter a valid number!!");
        }
    }
}while(true);


for(int i = 0; i < 8; i++)
{
     if (i == 5)
    {   

        //do not execute it just skip it
        continue;
    }
    Console.WriteLine(i);
}


//ternary - shortform of if statement
var message = age > 18 ? " He is an adult" : "He is a Child";
Console.WriteLine(message);