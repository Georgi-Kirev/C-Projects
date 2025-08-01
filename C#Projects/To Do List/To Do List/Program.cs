﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the to do list program.");
            List<string> TaskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add a task to the list");
                Console.WriteLine("Enter 2 to remove a task from the list");
                Console.WriteLine("Enter 3 to view the list");
                Console.WriteLine("Enter e to exit the program");

                option = Console.ReadLine();

                if (option == "1")
                {
                  Console.WriteLine("Please enter the task to add to the list");      
                    string task = Console.ReadLine();
                    TaskList.Add(task);
                    Console.WriteLine("Task is added to the list");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < TaskList.Count; i++)
                    {
                        Console.WriteLine(i + " : " + TaskList[i]);
                    } 

                    Console.WriteLine("Please enter the number of the task you wish to remove from the list.");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    TaskList.RemoveAt(taskNumber);
                }
                else if (option == "3")
                {
                    Console.WriteLine("Current tasks on the list : ");

                    for (int i = 0;i < TaskList.Count; i++)
                    {
                        Console.WriteLine(TaskList[i]);
                    }
                }
                else if (option == "e")
                {
                    Console.WriteLine("Exiting program");
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again");
                }
            }
            Console.WriteLine("Thank you for using the program!");
        }
    }
}
