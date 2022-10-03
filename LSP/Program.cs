using System;
using System.Collections.Generic;
using EmployeeLib;
using EmployeeLib.Interfaces;

namespace LSP {
    internal class Program {
        static void Main(string[] args) {

            EmployeeWithManager manager = new Manager();
            manager.FirstName = "Emma";
            manager.LastName = "Stone";
            manager.CalculatePerHourRate(4);

            IEmployee ceo = new CEO();
            ceo.FirstName = "Tom";
            ceo.LastName = "Lally";
            ceo.CalculatePerHourRate(2);


            List<EmployeeWithManager> employeesWithManager = new List<EmployeeWithManager>();
            EmployeeWithManager sales = new Sales();
            sales.AssignManager(manager);
            sales.FirstName = "Motasem";
            sales.LastName = "Armouti";

            employeesWithManager.Add(sales);

            EmployeeWithManager leadDeveloper = new LeadDeveloper();
            leadDeveloper.AssignManager(manager);
            leadDeveloper.FirstName = "Rasheed";
            leadDeveloper.LastName = "Rabatta";

            employeesWithManager.Add(leadDeveloper);

            EmployeeWithManager developer = new Developer();
            developer.AssignManager(leadDeveloper);
            developer.FirstName = "Marleen";
            developer.LastName = "Haddad";

            employeesWithManager.Add(developer);

            foreach(var employeeWithManager in employeesWithManager) 
            {
                Console.WriteLine($"{employeeWithManager.FirstName}'s salary is ${employeeWithManager.Salary}/hour."); 
            }


            Console.ReadLine();
        }
    }
}
