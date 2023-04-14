using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._1.Employee
{
    internal class EmployeePartTime : Employee                                                                          
    {
        private int work_hour;
        public EmployeePartTime(string id, string name, string address, int work_hour):base(id, name, address) 
        {
            work_hour = work_hour;
        } 

        public EmployeePartTime() { }

        public override void InputInfo()
        {
            Console.WriteLine("Enter ID: ");
            id = Console.ReadLine();
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            address = Console.ReadLine();
            Console.WriteLine("Enter Work Hour: ");
            work_hour = Int32.Parse(Console.ReadLine());
        }

        public override void PrintInfo()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("\n ID: {0} | Name: {0} | Address: {0} | Work hour: {0:D}" + id, name, address, work_hour);
            Console.WriteLine("----------------------------------------");
        }

        public override double calculateSalary()
        {
            return  work_hour * 15;
        }
    }
}
