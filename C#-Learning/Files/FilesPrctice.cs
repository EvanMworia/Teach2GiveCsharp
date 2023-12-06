using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class FilesPrctice
    {

        public void FilesPrac()
        {


            //directory

            //Directory.CreateDirectory(@"C:\Test");

            //var files = Directory.GetFiles(@"C:\Test","*.jpg", SearchOption.AllDirectories);
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            //Directory.Delete(@"C:\Test", true);

            //File CLass// FileInfo(instance)
            var path = @"C:\Test\data.txt";
            var path1 = @"C:\Test\data1.txt";
            //File.Create(path);
            var name1 = "Arthur Waheire";
            var name2 = "Zipeta Nabwala";

            File.WriteAllText(path,name1);//first line
            File.AppendAllText(path,"\n");//subsequent lines 
            File.AppendAllText(path,name2);

            //read

            var content = File.ReadAllText(path);
            var content1 = File.ReadAllLines(path);
            Console.WriteLine(content);

            foreach(var line in content1) Console.WriteLine(line);
            //Check if a file exists
            if (!File.Exists(path))
            {
                Console.WriteLine("Data file exist");
            }
            else
            {
                File.Create(path1);
            }





        }
    }
}
