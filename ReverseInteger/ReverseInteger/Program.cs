using ReverseInteger;



try
{
    do {
        Console.WriteLine("Input a number you want  to be reversed");
        string input = Console.ReadLine();
        if (input == "q") {
            break;
        }
       
         int numberReverse = IntInReverseOrder.reverseNumber(input);
         Console.WriteLine(numberReverse);
           

    } while (true);    
    
}
catch (Exception e)
{

    Console.WriteLine(e.Message);
}

