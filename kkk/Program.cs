using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "No.1";
            double c, f;
            Console.WriteLine("Calesius");
            c = double.Parse(Console.ReadLine());

            f = 1.8 * c + 32;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nOutput : Calesus = " + c + " Fahrenheit = " + f);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPrss any kuy to exit program");
            Console.ReadKey();
            /*
            */
            Console.Title = " No.2";
            int num1, num2;
            long sum, mul;
            Console.Write("Input Number1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Input Number2 : ");
            num2 = int.Parse(Console.ReadLine());
            sum = num1 + num2;
            mul = num1 * num2;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nOutput");
            Console.WriteLine("\t" + num1 + " + " + num2 + " = " + sum);
            Console.WriteLine("\t" + num1 + " + " + num2 + " = " + mul);
            Console.Write("\nPress any key to exit program");
            Console.ReadKey();
            /*
          
             */
            Console.Title = "No.3";
            Console.Write("Input Name");
            string name = Console.ReadLine();
            Console.Write("Input Sale");
            double sale = double.Parse(Console.ReadLine());
            double commission = 0.3 * sale;
            Console.WriteLine();
            Console.Write("Name : " + name);
            Console.Write("\n Sale: " +sale + "bahts.");
            Console.Write("\nCommiss : " + commission + "bahts.");
            Console.ReadLine();
            /*
            */
            Console.Title = "No.4";
            Console.Write("Input Attention");
            int Attention = int.Parse(Console.ReadLine());
            Console.Write("Input Assignment");
            int Assignment = int.Parse(Console.ReadLine());
            Console.Write("Input Midterm");
            int Midterm = int.Parse(Console.ReadLine());
            Console.Write("Input Final");
            int Final = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int total = (Attention + Assignment + Midterm + Final);
            Console.WriteLine("total Score" + total);
            Console.ReadLine();
            /*
            */
            Console.Title = "No.5";
            Console.Write("Input name:");
            string Name = (Console.ReadLine());
            Console.Write("Input Salary:");
            int salary = int.Parse(Console.ReadLine());
            Console.Write("Input hour:");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("Input Tax:");
            int ot = hour * 200;
            int salary2 = salary + ot;
            double tax = salary2 * 0.1;
            double total1 = salary2 - tax;
            Console.WriteLine("Name" + name);
            Console.WriteLine("\nSalary" + salary);
            Console.WriteLine("\nOvertime" + ot + "bahts");
            Console.WriteLine("\nTax" + tax + "bahts");
            Console.WriteLine("\nNet Salary" + total + "bahts");
            Console.ReadLine();




        }
    }
}
