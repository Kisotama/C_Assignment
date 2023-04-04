using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Student
    {
        private String id;
        private String name;
        private String age;
        private String address;
        private List<Student> students;

        public Student(string id, string name, string age, string address)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public Student(String id)
        {
            this.id = id;
        }

        


        public Student() { }

        public void DisplayInfo()
        {
            Console.WriteLine("\n - Id: " + id);
            Console.WriteLine("\n - Name: " + name);
            Console.WriteLine("\n - Age: " + age);
            Console.WriteLine("\n - Address: " + address);
        }

        public void InputInfo()
        {
            Console.WriteLine("Input Id: ");
            id = Console.ReadLine();
            Console.WriteLine("Input Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Input Age: ");
            age = Console.ReadLine();
            Console.WriteLine("Input Address: ");
            address = Console.ReadLine();
        }

        public void UpdateInfo()
        {
            Console.WriteLine("Input Id: ");
            id = Console.ReadLine();
            Console.WriteLine("Input Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Input Age: ");
            age = Console.ReadLine();
            Console.WriteLine("Input Address: ");
            address = Console.ReadLine();
        }

        public String Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

    }

}
