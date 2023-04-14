using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab2._1.Employee
{

    internal class Employee
    {
        protected string id;
        protected string name;
        protected string address;

        public Employee(string id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public Employee()
        {

        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        { get { return name; } set {  name = value; } }
        public string Address
        { get { return address; } set {  address = value; } }
    
        public virtual void InputInfo()
        {
            Console.WriteLine("Enter ID: ");
            id = Console.ReadLine();
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            address = Console.ReadLine();
        }
        
        public virtual void PrintInfo()
        {
            Console.WriteLine("------------Employee INFO---------------");
            Console.WriteLine("\n - ID: " + id);
            Console.WriteLine("\n - Name: " + name);
            Console.WriteLine("\n - Adress: " + address);
            Console.WriteLine("----------------------------------------");
        }

        public virtual double calculateSalary()
        {
            return 0;
        }
    }


}
