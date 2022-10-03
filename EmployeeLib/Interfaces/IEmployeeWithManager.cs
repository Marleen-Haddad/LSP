using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLib.Interfaces
{
    public interface IEmployeeWithManager
    {
        public EmployeeWithManager Manager { get; set; }
        public void AssignManager(EmployeeWithManager manager);
        public void GeneratePerformanceReview();

    }
}
