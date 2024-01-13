using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)  
        {
            int num1,num2;
            string answer;
            int result;
            Console.WriteLine("Hello, Welcome to the Calculator program");

            Console.WriteLine("Please enter your first number.");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number.");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter a,s,m or d");

            answer = Console.ReadLine();

            if(answer == "a")
            {
                result = num1 + num2;
            }
            else if(answer == "s") 
            { 
                result = num1 - num2;
            }
            else if(answer == "m")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

            Console.WriteLine("You result is " + result);
            Console.WriteLine("Thanks for using the calculator");
            Console.ReadKey();
        }
    }
}
