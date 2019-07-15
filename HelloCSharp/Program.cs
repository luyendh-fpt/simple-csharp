using System;
using System.Collections.Generic;
using HelloCSharp.controller;
using HelloCSharp.entity;
using HelloCSharp.model;
using MySql.Data.MySqlClient;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateMenu();
        }

        private static void GenerateMenu()
        {
            var studentController = new StudentController();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===================STUDENT MANAGER================");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Show List Student");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.WriteLine("===================================================");
                Console.WriteLine("Please enter your choice: ");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:                        
                        studentController.CreateStudent();
                        break;
                    case 2:                        
                        studentController.ShowList();
                        break;
                    case 3:
                        studentController.UpdateStudent();
                        break;
                    case 4:
                        studentController.DeleteStudent();
                        break;
                    case 5:
                        Console.WriteLine("Close application!");
                        break;
                    default:
                        Console.WriteLine("Please choice from 1 to 5!");
                        break;
                }                
                if (choice == 5)
                {
                    Console.WriteLine("See you again!");
                    break;
                }
                Console.WriteLine("Press any key to continue!");
                Console.Read();                
            }
        }
    }
}