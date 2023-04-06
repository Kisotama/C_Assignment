using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab2
{
    class Menu
    {
        private ArrayList studentlist;

        public Menu()
        {
            this.studentlist = new ArrayList();
        }
        public void AddStudent()
        {
            Student add_stu = new Student();
            add_stu.Inputinfo();
            studentlist.Add(add_stu);
        }
        public void DisplayStudent()
        {
            foreach(Student student in studentlist)
            {
                student.Displayinfo();
            }
        }
        public void find_student_id(int id)
        {
            bool found = false;
            foreach(Student student in studentlist)
            {
                if (student.studentid == id)
                {
                    student.Displayinfo();
                    found = true;
                    break;
                }
            }
            if(!found)
            {
                Console.WriteLine("Invalid ID" + id);
            }
        }
        public void findthehighestandthelowest()
        {
            if (studentlist.Count > 0)
            {
                float highest = ((Student)studentlist[0]).average;
                float lowest = ((Student)studentlist[0]).average;

                foreach (Student student in studentlist)
                {
                    if (student.average > highest)
                    {
                        highest = student.average;
                    }

                    if (student.average < lowest)
                    {
                        lowest = student.average;
                    }
                }

                Console.WriteLine("\n Highest Average: " + highest);
                Console.WriteLine("\n Lowest Average: " + lowest);
            }
            else
            {
                Console.WriteLine("Student list is empty!");
            }
        }

      

        public void Scholarship()
        {
            foreach(Student student in studentlist)
            {
                if (student.average >= 8)
                {
                    Console.WriteLine("\n Congratulation!, The Scholarship now is yours");
                    student.Displayinfo();
                }
            }
        }
    }
}
