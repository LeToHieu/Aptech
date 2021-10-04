using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class EmployeeManagement
    {
        private List<TemporaryEmp> listEmployee = new List<TemporaryEmp>();        
        public void InputEmployee()
        {
            //input_imployees => php, ruby, python,....
            string choice = "y";
            int i = 0;
            listEmployee.Clear();
            while (true)
            {
                i++;
                Console.WriteLine($"Input information of employee {i}:");
                TemporaryEmp employee = new TemporaryEmp();
                employee.Input();
                listEmployee.Add(employee);
                Console.WriteLine("Do you want to continue(Y/N) ?");
                choice = Console.ReadLine();
                if (choice.ToLower().Equals("n")) {
                    break;
                }
            }            
        }
        public void DisplayEmployees()
        {
            foreach(TemporaryEmp employee in listEmployee)
            {
                employee.DisplayDetail();
            }
        }
        public void DisplayMaxNumWork()
        {
            int maxNumWork = listEmployee.Max(item => item.NumWork);
            TemporaryEmp foundEmployee = listEmployee.Where(eachEmployee => eachEmployee.NumWork == maxNumWork).First();
            Console.WriteLine("Employee with max numwork:");
            foundEmployee.DisplayDetail();
        }
    }
}
