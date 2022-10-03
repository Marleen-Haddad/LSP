using EmployeeLib.Interfaces;
using System;

namespace EmployeeLib
{
    public class CEO : IEmployee
    {
        public string FirstName { get ; set ; }
        public string LastName { get; set; }
        public decimal Salary { get ; set ; }

        public void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount * rank;
        }

        public void FireSomeone()
        {
            // Simulate firing someone
            Console.WriteLine("You're Fired!");
        }
    }
}
