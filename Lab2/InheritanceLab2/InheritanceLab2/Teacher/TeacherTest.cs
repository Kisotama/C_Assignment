using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab2.Teacher
{
    internal class TeacherTest
    {
        public static void TeacherManage()
        {
            ManageTeacher menu = new ManageTeacher();
            int choice;

            while (true)
            {
                try
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("============ Teacher Management ===========");
                        Console.WriteLine("\n   1.Add a new teacher ");
                        Console.WriteLine("\n   2.Show all teachers ");
                        Console.WriteLine("\n   3.Search by name ");
                        Console.WriteLine("\n   4.Display teachers who have max salary ");
                        Console.WriteLine("\n   5.Exit ");
                        Console.WriteLine("===========================================");
                        Console.WriteLine("\n Please Input the number.");
                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.Clear();
                                menu.AddTeacher();
                                break;
                            case 2:
                                Console.Clear();
                                menu.DisplayTeacher();
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.Clear();
                                String name = Console.ReadLine();
                                menu.Find_teacher_by_Name(name);
                                break;
                            case 4:
                                Console.Clear();
                                menu.Display_Salary();
                                break;
                            case 5:
                                Console.WriteLine("Back to Main Menu");
                                Console.Clear();
                                return;
                        }
                    } while (choice != 0);
                    Console.WriteLine("Invalid Number");
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Nah");
                }
            }
        }
    }
}
    

