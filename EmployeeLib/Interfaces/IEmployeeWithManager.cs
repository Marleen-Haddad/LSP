using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLib.Interfaces
{
    public interface IEmployeeWithManager
    {
        public Employee Manager { get; set; }
        public void AssignManager(Employee manager);
    }
}
