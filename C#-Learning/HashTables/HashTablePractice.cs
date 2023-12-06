using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HashTables
{
    internal class HashTablePractice
    {
       

        public void hashTablePrac()
        {
            //initializer
            Hashtable car = new Hashtable()
        {
            {"carName", "Mercedes Benz" }// boxing
        };

            //Add Method
            car.Add("Mileage",3);
            car.Add("Model", "2016");
            //Accessing
            //using the Keys
            Console.WriteLine(car["carName"]);

            //foreach Loop
          
            //Check if it Exists

            //Console.WriteLine(car.Contains("carName"));
            //Console.WriteLine(car.Contains("name"));

            //Console.WriteLine(car.ContainsKey("Model"));

            if (car.ContainsKey("Model"))
            {
                //updating
                car["Model"] = "2023";

            }
            else
            {   

                //add it
                car.Add("Model", "2023");

            }


            

            car["color"] = "Black";
           


            //
            //car.Remove("color");
            //car.Clear();
            foreach (var key in car.Keys)
            {
                Console.WriteLine($" {key}: {car[key]}");
            }

            foreach(DictionaryEntry entry in car)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }

            //Console.WriteLine(car.ContainsValue(3));
            //Console.WriteLine(car.ContainsValue(true));
        }

       
        



    }
}
