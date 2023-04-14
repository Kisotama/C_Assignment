using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._1.Employee
{
    internal class EmployeeManage : Employee
    {
        List<Employee> list = new List<Employee>()  ;

        public EmployeeManage(List<Employee> list)
        {
            this.list = list;
        }

        public EmployeeManage() { }

        public void addEmployee()
        {
            Console.WriteLine("Which type of employee do you want to add? Enter 1 for Full-time, 2 for Part-time.");
            int employeeType = Convert.ToInt32(Console.ReadLine());

            Employee employee;

            if (employeeType == 1)
            {
                employee = new EmployeeFulltime();
                Console.WriteLine("Adding Full-time Employee");
            }
            else if (employeeType == 2)
            {
                employee = new EmployeePartTime();
                Console.WriteLine("Adding Part-time Employee");
            }
            else
            {
                Console.WriteLine("Invalid employee type!");
                return;
            }

            employee.InputInfo();
            list.Add(employee);
        }
        public void show_PartTime_Employee()
        {
            Console.WriteLine("------------List of Part Time Employee INFO---------------");
            foreach (Employee _employ in list)
            {
                if ( _employ is EmployeePartTime)
                {
                    _employ.PrintInfo();
                    Console.WriteLine("Salary: " + _employ.calculateSalary);
                }
            Console.WriteLine("----------------------------------------------------------");
            }
        }

        public void showEmployee()
        {
            Console.WriteLine("------------List of Employee INFO---------------");
            foreach (Employee _employ in list)
            {
                _employ.PrintInfo();
                Console.WriteLine("Salary: " + calculateSalary);
            }
            Console.WriteLine("----------------------------------------");
        }

        public void SeachID(string id)
        {
            foreach (Employee _employ in list)
            {
                if(_employ.ID == id)
                {
                    Console.WriteLine(" Found Employee with ID " + id + ":");
                    _employ.PrintInfo();
                    Console.WriteLine(" Salary: " + calculateSalary);
                    return;
                }
            }
            Console.WriteLine(" Cannot find Employee with ID " + id);
        }
    }
}
