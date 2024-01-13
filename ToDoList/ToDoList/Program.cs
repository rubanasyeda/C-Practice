using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To DO list program");
            List<string> taskList = new List<string>();
            string option = "";

            while(option != "e")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add a task to the list");
                Console.WriteLine("Enter 2 to remove a task to the list");
                Console.WriteLine("Enter 3 to view the list");
                Console.WriteLine("Enter any other key to exit the program");

                option = Console.ReadLine();

                if(option == "1")
                {
                    Console.WriteLine("Please enter the task to add to the list");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Task is added to the list");
                }
                else if(option == "2")
                {
                    for(int i=1; i< taskList.Count + 1; i++)
                    {
                        Console.WriteLine(i+" : "+ taskList[i-1]);
                    }
                    Console.WriteLine("Please enter the task number to remove that task");
                    int tasknum = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(tasknum-1);
                    Console.WriteLine("Your task has been removed");
                }
                else if(option == "3")
                {
                    Console.WriteLine("Current tasks in the list are:");
                    for (int i = 1; i < taskList.Count + 1; i++)
                    {
                        Console.WriteLine(i + " : " + taskList[i-1]);
                    }

                }
                else if(option=="e")
                {
                    Console.WriteLine("Exiting program");
                }
                else
                {
                    Console.WriteLine("Invalid key");
                }
            }

            Console.WriteLine("Thanks for using the program");

        }
    }
}
