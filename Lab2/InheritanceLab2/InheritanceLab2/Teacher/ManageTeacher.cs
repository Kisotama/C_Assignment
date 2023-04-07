using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab2
{
    internal class ManageTeacher
    {
        private ArrayList Teachers;

        public ManageTeacher()
        {
            Teachers = new ArrayList();
        }

        public void AddTeacher()
        {
            Teachers teacher = new Teachers();
            teacher.Inputinfo();
            Teachers.Add(teacher);
        }

        public void DisplayTeacher() 
        {
            foreach (Teachers teacher in Teachers) 
            {
                teacher.Displayinfo();
             
            }
        }


        public double Max_Salary()
        {
            double Max_salary = 0;
            foreach (Teachers teacher in Teachers)
            {
                double salary = teacher.Calculate_Salary();
                if (salary > Max_salary)
                {
                    Max_salary = salary;
                }
            }
            return Max_salary;
        }
        

        public void Display_Salary()
        {
                double maxSalary = Max_Salary();
                Console.WriteLine(" Teachers with the highest salary: ");
                foreach (Teachers teacher in Teachers)
                {
                    if (teacher.Calculate_Salary() == maxSalary)
                    {
                        teacher.Displayinfo();
                    Console.WriteLine("Salary : " + maxSalary);
                    }
                }
            }
        

        public void Find_teacher_by_Name(string name)
        {
            foreach(Teachers teacher in Teachers)
            {
                if (teacher.Name == name)
                {
                    teacher.Displayinfo();
                    break;
                }
                else Console.WriteLine(" There is no teachere with name :" + name);
            }
        }

        
    }
}
