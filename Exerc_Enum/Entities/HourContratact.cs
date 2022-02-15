using System;


namespace Exerc_Enum.Entities
{
    class HourContratact
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //Construtores
        public HourContratact(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //Metodo
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }

    }
}
