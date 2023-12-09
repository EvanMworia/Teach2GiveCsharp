using HospitalManagementSystem.Data;
using HospitalManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.ConsoleUi
{
    public class ConsoleUiController
    {
        CrudOperations operations =new();
        public void userInterface(DataContext context)
        {
            Console.WriteLine("\t\t\tHOSPITAL MANAGEMENT SYSTEM");
            Console.WriteLine("\t\t\t_____________________________");
            Console.WriteLine("Select a service based on the number");            
            Console.WriteLine("\t\t 1. Book an Appointment");
            Console.WriteLine("\t\t 2. Find A Patient By Name");
            Console.WriteLine("\t\t 3. Find A Patient By Id");
            Console.WriteLine("\t\t 4. See Available Rooms/Wards");
            string? userChoice= Console.ReadLine();
            var validOptions = new List<string>() { "1", "2", "3", "4",};
            
        }
          
    }

       
       


}

