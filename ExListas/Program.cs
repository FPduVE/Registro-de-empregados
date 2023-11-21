using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExListas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employees> list = new List<Employees>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee: {i}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employees(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());
            Employees emp = list.Find(x => x.Id == searchId);
            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double porcetage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(porcetage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }



            Console.WriteLine("Updated list of employees:");
            foreach(Employees obj in list)
            {
                Console.WriteLine(obj);
            }
        }

        
    }
}
