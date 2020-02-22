using System;
using Logging;

namespace Introduction.Persons
{
    public class TeamMember:Person
    {
        public DateTime Anniversary { get; set; }
        public Person TeamLeader { get; set; }

        public decimal Salary { get; set; }

        public void SayHi(string text)
        {
            Console.WriteLine(text);
        }

        public decimal GiveRaise(decimal howMuch)
        {
            var effectiveDate = DateTime.Now;
            return GiveRaise(howMuch, effectiveDate);
        }

        public decimal GiveRaise(decimal howMuch, DateTime effectiveDate)
        {
            Salary = CalculateRaise(Salary, howMuch);
            Logger.Log("New Salary calculated");
            return Salary;
        }

        public decimal GiveRaise(string raiseAmount)
        {
            var raiseAmountInDecimal = decimal.Parse(raiseAmount);
            return GiveRaise(raiseAmountInDecimal);
        }

        public decimal GiveRaise(decimal raiseAmount, bool isPercent)
        {
            if (isPercent)
            {
                return GiveRaise(Salary*raiseAmount);
            }
            else
            {
                return GiveRaise(raiseAmount);
            }
        }

        public void AddVacationTime(int numberOfDay = 10)
        {

        }

        public void GiveRaise1(decimal howMuch)
        {
            Salary += howMuch;
        }

        private decimal CalculateRaise(decimal salary, decimal raiseAmount )
        {
            return salary + raiseAmount;
        }
    }
}