using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab2
{
    class Person:Object
    {
        protected string name;
        protected string gender;
        protected string dob;
        protected string address;

        public Person(string name, string gender, string dob, string address)
        {
            this.name = name;
            this.gender = gender;
            this.dob = dob;
            this.address = address;
        }

        public Person()
        {
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string DoB
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }



        public virtual void Displayinfo()
        {
            Console.WriteLine("\n - Name: " + name);
            Console.WriteLine("\n - Gender: " + gender);
            Console.WriteLine("\n - Date of Birth: " + dob);
            Console.WriteLine("\n - Address: " + address);
        }

        public virtual void Inputinfo()
        {
            Console.WriteLine("Input Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Input Gender: ");
            gender = Console.ReadLine();
            Console.WriteLine("Input Date of Birth: ");
            dob = Console.ReadLine();
            Console.WriteLine("Input Address: ");
            address = Console.ReadLine();
        }
    }
}
