using EmployeeLib.Interfaces;
using System;

namespace EmployeeLib
{
    public abstract class Employee : IEmployee, IEmployeeWithManager
    {
        public string FirstName { get  ; set ; }
        public string LastName { get; set; }
        public decimal Salary { get ; set ; }
        public Employee Manager { get; set ; }

        public void AssignManager(Employee manager)
        {
            Manager = manager;
        }

        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }
    }
}
