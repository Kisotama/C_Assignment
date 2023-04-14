using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab2._1.Employee
{
    internal class EmployeeFulltime : Employee
    {
        double basic_salary;
        int overtime;
        int TypeOfPosition;

        public EmployeeFulltime(string id, string name, string address,
            double basic_salary, int overtime, int typeOfPosition)
            : base(id, name, address)
        {
            basic_salary = basic_salary;
            overtime = overtime;
            TypeOfPosition = typeOfPosition;
        }

        public EmployeeFulltime()
        {
        }

        public override void InputInfo()
        {
            Console.WriteLine("Enter ID: ");
            id = Console.ReadLine();
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            address = Console.ReadLine();
            Console.WriteLine("Enter Basic Salary: ");
            basic_salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Over Time: ");
            overtime = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Type Of Position (1: Employee, 2: Boss, 3: Manager): ");
            TypeOfPosition = Int32.Parse(Console.ReadLine());

        }

        public override void PrintInfo()
        {
            Console.WriteLine("------------Employee INFO---------------");
            Console.WriteLine("\n - ID: " + id);
            Console.WriteLine("\n - Name: " + name);
            Console.WriteLine("\n - Adress: " + address);
            Console.WriteLine("\n - Basic Salary: " + basic_salary);
            Console.WriteLine("\n - Over Time: " + overtime);
            Console.WriteLine("\n - Type Of Position : " + TypeOfPosition);
            Console.WriteLine("----------------------------------------");
        }

        public override double calculateSalary()
        {
            double bonus = 0;
            double salary = 0;
            switch (TypeofPotistion)
            {
                case 1:
                    bonus = 200;

                    break;

                case 2:
                    bonus = 300;
                    break;

                case 3:
                    bonus = 500;

                    break;
                default:
                    break;

            }
            salary = basic_salary + bonus + (overtime * 50);
            return salary;

        }

        public double Basic_Salary
        {
            get { return basic_salary; }
            set { basic_salary = value; }
        }

        public int Overtime
        {
            get { return overtime; }
            set { overtime = value; }
        }

        public int TypeofPotistion
        {
            get { return TypeOfPosition; }
            set { TypeOfPosition = value; }


        }
    }
}
