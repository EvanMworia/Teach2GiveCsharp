using System;
using System.Reflection;

namespace Datatpes.TypeConversion
{
    public class TypeConvertClass
    {

        public void implicitConversion()
        {
//  The two data types are compatible
//  When we assign a value of  a smaller data type to a bigger data type.
//  The following is a diagram to illustrate possible conversions

            byte num1 = 12;
            short num7 = num1;
            int num2 = num1;
            long num3 = num2;
            float num4 = num3;
            double num5 = num4;
            
        }

        public void explicitConversion()
        {
            //Here we convert large data types(like double, long)
            //to smaller data types like(int, byte, short, float).
            //There is a chance of data loss or  failed conversion
            //for some reasons, so this is  unsafe type of conversion.

            int num1 = 350;
            byte num2 = (byte) num1;//might lose data
            Console.WriteLine(num2);
            
        }

        public void nonCompatibleTypes()
        {
            string num1 = "100";

            //Convert,Parse, TryParse
            //if not possible it will throw an exception 
            int num2 = Convert.ToInt32(num1);
            Console.WriteLine(num2);
            

            string b1 = "true";
            bool b2= Convert.ToBoolean(b1);
            Console.WriteLine(b2);

            //Parse
            //if not possible it will throw an exception 
            int num3 = int.Parse(num1);
            Console.WriteLine(num3);

            //TryParse -- exception thrown but not handled 

            string num5 = "100";

            bool b4 = int.TryParse(num5, out int num6);
            if (b4)
            {
                Console.WriteLine(num6);
            }
            else
            {
                Console.WriteLine("Operation Not Possible !!!");
            }

        }
    }
}
