using Exerc_Enum.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Enum.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Worker(string name, WorkLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }


    }
}
