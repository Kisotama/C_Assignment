using InheritanceLab2.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choices;
           
           
            do
            {
                Console.WriteLine("==========MAIN MENU==========");
                Console.WriteLine("1. Teacher Menu");
                Console.WriteLine("2. Student Menu");
                Console.WriteLine("3. Exit");
                Console.WriteLine("=============================");
                Console.Write("Enter your choice: ");
                choices = Int32.Parse(Console.ReadLine());
                
                switch (choices)
                {
                    case 1:
                        Console.Clear();
                        TeacherTest.TeacherManage();
                        break;
                    case 2:
                        Console.Clear();
                        StudentTest.StudentManage();
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }
            } while (choices != 0);
        }
    }
}
