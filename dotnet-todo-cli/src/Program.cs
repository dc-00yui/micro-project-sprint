using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace dotnet_todo_cli
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the To-Do List Application");
                Console.WriteLine("1. View To-Do Items");
                Console.WriteLine("2. View Completed Tasks");
                Console.WriteLine("3. Add/Edit Task");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        ShowTodos();
                        break;
                    case "2":
                        ShowCompletedTasks();
                        break;
                    case "3":
                        ManageTask();
                        break;
                    case "4":
                        Console.WriteLine("Exiting the application...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                if (option != "4")
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

            } while (option != "4");
        }

        static void ShowTodos()
        {
            // Logic to display to-do items
            Console.WriteLine("Displaying To-Do Items...");
            // Call TodoHandler to fetch and display items
        }

        static void ShowCompletedTasks()
        {
            // Logic to display completed tasks
            Console.WriteLine("Displaying Completed Tasks...");
            // Call TodoHandler to fetch and display completed items
        }

        static void ManageTask()
        {
            // Logic to add or edit a task
            Console.WriteLine("Managing Task...");
            // Call TodoHandler to create or update a task
        }
    }
}