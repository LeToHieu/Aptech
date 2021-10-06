using System;
using System.Collections.Generic;
namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManagement employeeManagement = new EmployeeManagement();
            /*
            employeeManagement.InputEmployee();
            employeeManagement.SearchEmployee();
            employeeManagement.DisplayEmployees();
            */            
            employeeManagement.ListEmployee = new List<TemporaryEmp> {  
                new TemporaryEmp() { 
                    EmpID = 11,
                    EmpName = "Nguyen Van A",
                    DOB = new DateTime(1989,25,12),
                    Department = "IT",
                    NumWork = 2,
                    WorkDay = 10,
                },
                new TemporaryEmp() {
                    EmpID = 11,
                    EmpName = "Nguyen Van A",
                    DOB = new DateTime(1989,25,12),
                    Department = "IT",
                    NumWork = 2,
                    WorkDay = 10,
                }
            };
        }
    }
}
