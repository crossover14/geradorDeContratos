using Exerc_Enum.Entities.Enums;
using System.Collections.Generic;

namespace Exerc_Enum.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }

        //Importar uma do HourContrat por ser uma lista usa o termo "List<>"
        public List<HourContratact> Contrats { get; set; } = new List<HourContratact>();
        

        //construtores
        public Worker()
        {
          
        }

        public Worker(string name, WorkLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }
        //contrutores Nao incluir associaçoes para muitos "Contrato" nao add LIST<> ela sempre começa vazia VIA DE REGRA


    }
}
