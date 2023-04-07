using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab2
{
    internal class Teachers : Person
    {
        public string course;
        public double hour_salary;
        public int course_hour;

        public Teachers(string name, string gender, string dob,
            string address, string course, double hour_salary, int course_hour)
            : base(name, gender, dob, address)
        {
            this.course = course;
            this.hour_salary = hour_salary;
            this.course_hour = course_hour;
        }

        public Teachers()
        {
        }

        public override void Inputinfo()
        {
            base.Inputinfo();
            Console.WriteLine(" Input Course here: ");
            course = Console.ReadLine();
            Console.WriteLine(" Input hour salary here: ");
            hour_salary = double.Parse(Console.ReadLine());
            Console.WriteLine(" Input course hour taught here: ");
            course_hour = Int32.Parse(Console.ReadLine());
        }

        public override void Displayinfo()
        {
            Console.WriteLine("------------Teacher INFO---------------");
            Console.WriteLine("\n - Name : " + name);
            Console.WriteLine("\n - Gender : " + gender);
            Console.WriteLine("\n - Date of Birth : " + dob);
            Console.WriteLine("\n - Address : " + address);
            Console.WriteLine("\n - Course : " + course);
            Console.WriteLine("\n - Salary/hr : " + hour_salary);
            Console.WriteLine("\n - Time taught : " + course_hour);
            Console.WriteLine("\n - Salary: " + Calculate_Salary());
            Console.WriteLine("----------------------------------------");
        }

        public double Calculate_Salary()
        {
            double salary = 0;
            if (course == "G" || course == "H" || course == "I" || course == "K")
            {
                salary = hour_salary * course_hour;
            }
            else if (course == "L" || course == "M")
            {
                salary = (hour_salary * course_hour) + 200000;
            }
            return salary;
        }
    }
}
