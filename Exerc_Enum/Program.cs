using Exerc_Enum.Entities;
using System;
using Exerc_Enum.Entities.Enums;
using System.Globalization;

namespace Exerc_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine();
            
            
            Console.Write("Enter worker data: ");
           
            
            Console.Write("Name: ");
            string name = Console.ReadLine();
            
            
            Console.Write("Level (Junior/MidLevel/Senior): ");
            //Conversão de ENUM para string
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());

            Console.WriteLine("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);
           



        }
    }
}
