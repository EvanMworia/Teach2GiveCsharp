
namespace Datatpes.Numeric
{
    public  class NumericClass
    {

        public void learningNumbers()
        {
            //whole numbers - 4 dataypes -byte,short,int,long

            //Byte
            //holds numbers between 0 - 255 //byte
            byte age = 255;
            //Console.WriteLine(age);

            //short  16 bits
            //only positive numbers ushort
            ushort num1 = 64000;//only supports +ve numbers 

            Console.WriteLine($"the minumun number a short type can have is {short.MinValue}");
            Console.WriteLine($"the maximum number a short type can have is {short.MaxValue}");

            //Int
            // int 32 bits /4 bytes
            Console.ReadLine();
            Console.WriteLine($"the minumun number a int type can have is {int.MinValue}");
            Console.WriteLine($"the maximum number a int type can have is {int.MaxValue}");
            int num7 = 12;
            Int32 num8 = 76;
            //long
            //long 64 bits = 8 bytes
            Console.ReadLine();
            Console.WriteLine($"the minumun number a long type can have is {long.MinValue}");
            Console.WriteLine($"the maximum number a long type can have is {long.MaxValue}");


        }

        public void learningRealNumbers()
        {
            //in Real Numbers we have three types = float ,double(var) , decimal
            //float
            Console.WriteLine($"the minumun number a float type can have is {float.MinValue}");
            Console.WriteLine($"the maximum number a float type can have is {float.MaxValue}");
            float num4 = 2.34f;
            //double
            Console.WriteLine($"the minumun number a double type can have is {double.MinValue}");
            Console.WriteLine($"the maximum number a double type can have is {double.MaxValue}");
            double num5 = 2.45;

            //decimal
            Console.WriteLine($"the minumun number a decimal type can have is {decimal.MinValue}");
            Console.WriteLine($"the maximum number a decimal type can have is {decimal.MaxValue}");
            decimal num6 = 2.34m;
        }


        public void learningChar()
        {
            char grade = 'A';

            var grade1 = 'B';

            var message = " The coach said \n \t\'We played Well\' ";
            Console.WriteLine(message);

        }

        public void learningBoolean()
        {
            bool isLegal;
            Boolean isTrue=false;
                
        }
    }

}
