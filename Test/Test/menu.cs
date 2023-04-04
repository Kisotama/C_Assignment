using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Test
{
    internal class menu
    {
        private ArrayList studentList;

        public menu()
        {
            this.studentList = new ArrayList();
        }

        public void AddStudent()
        {
            Student new_stu = new Student();
            new_stu.InputInfo();
            studentList.Add(new_stu);
        }

        public void DisplayAllStudent()
        {
            foreach (Student student in studentList)
            {
                student.DisplayInfo();
            }
        }
        public void SearchStudentById(String id)
        {
            foreach (Student student in studentList)
            {
                if (student.Id == id)
                {
                    student.DisplayInfo();
                    break;
                }
                else Console.WriteLine("There is no student with ID: " + id);
            }
        }

        public void SearchStudentByName(String name)
        {
            foreach (Student student in studentList)
            {
                if (student.Name == name)
                {
                    student.DisplayInfo();
                    break;
                }
                else Console.WriteLine("There is no student with Name: " + name);
            }
        }

        public void RemoveStudent(String id)
        {
            foreach (Student student in studentList)
            {
                if (student.Id == id)
                {
                    this.studentList.Remove(student);
                    Console.WriteLine("A Student with ID: ${id} has been removed");
                    break;
                }
                else
                {
                    Console.WriteLine("Cannot find a Student with ID: ${id} to remove");
                }
            }
        }

        public void UpdateStudent(String id)
        {
            foreach (Student student in studentList)
            {
                if (student.Id == id)
                {
                    student.UpdateInfo();
                    break;
                }
                else
                {
                    Console.WriteLine("There is no student with ID: \" + id");
                }
            }
        }
    }
}

    

