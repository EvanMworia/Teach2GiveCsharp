
var a = 12;
var b=13;//assignement operator   
//Addition Operator(+)       -The + operator adds two operands

var addition = a + b;
Console.WriteLine(addition);
//Subtraction Operator (-)    -The – operator subtracts two operands.
var sub = a - b;
Console.WriteLine(sub);
//Multiplication Operator (*) - The* operator multiplies two operands.
var mul = a * b;
Console.WriteLine(mul);
//Division Operator (/)       -The / operator divides two operands.
var div = a / b;
Console.WriteLine(div);
//Modulus Operator (%)    -The % operator returns the remainder when the first operand is 	
var mod = a % b;
Console.WriteLine(mod);
//Assignement Operators
//addition assignent(+=)

//var c= a += 10; //a+10
//Console.WriteLine(c);

var d = a -= 2;//a-2
Console.WriteLine(d);


//Relational Operators
Console.WriteLine(2==2);
Console.WriteLine(3!=3);
Console.WriteLine(3>=4);
Console.WriteLine(3<= 4);



// Logical Operators
//OR(||)
/// true || true==true
/// true || false==true
/// false|| true==true
/// false || false==false
/// 
/// AND (&)
/// true && true==true
/// true && false==false
/// false && true==false
/// false &&| false==false
/// 
/// LOgical NOT(!)
/// true==false
/// false==true
/// 
//if(a>5 || a >20)
//{
//    Console.WriteLine("Between 5 and 20");
//}



var x = 10;
var y = x++;//y is assigned first then x is incremented // (y=10) (x=11)
Console.WriteLine(y);//10
Console.WriteLine(x);//11

var z = 10;
var e = ++z; //z is incremented then assigned to e
Console.WriteLine(z);//11
Console.WriteLine(e);//11


if (e < 15)
{
    Console.WriteLine("Hello");
}
else
{
    Console.WriteLine("world");
}

var res=e > 15 ? "Hello" :e>10? "Helloworld": "world";
Console.WriteLine(res);