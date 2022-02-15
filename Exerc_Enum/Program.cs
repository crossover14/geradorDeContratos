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
            
            
            Console.WriteLine("Enter worker data: ");
           
            
            Console.Write("Name: ");
            string name = Console.ReadLine();
            
            
            Console.Write("Level (Junior/MidLevel/Senior): ");
            //Conversão de ENUM para string
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);


            Console.Write("How many contract to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i}  contrat data: ");
                Console.Write( "Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hour): ");
                int hours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                HourContratact contratact = new HourContratact(date, valuePerHour, hours);

                worker.AddContract(contratact);

            }

            Console.WriteLine("");
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYEar = Console.ReadLine();
            int month = int.Parse(monthAndYEar.Substring(0, 2));
            int year = int.Parse(monthAndYEar.Substring(3));
            Console.WriteLine("Name " + worker.Name);
            //Navegue Usando operador ". (PONTO)"
            Console.WriteLine("Departament: " + worker.Departament.Name);

            Console.WriteLine("Icome for " + monthAndYEar + ": " + worker.Icome(year, month).ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
