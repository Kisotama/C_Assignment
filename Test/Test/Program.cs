using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            menu student_list = new menu();

            int option;

            while (true)
            {
                try
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("\n\t--------------- MENU ---------------n");
                        Console.WriteLine("\t1. Add \n");
                        Console.WriteLine("\t2. Display . \n");
                        Console.WriteLine("\t3. Search by name \n");
                        Console.WriteLine("\t4. Search by Id \n");
                        Console.WriteLine("\t5. Remove by Id\n");
                        Console.WriteLine("\t6. Update by Id\n");
                        Console.WriteLine("\t7. Exit\n");
                        Console.WriteLine("\t------------------------------n");
                        Console.Write("\tChoose it bruh: ");
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.Clear();
                                student_list.AddStudent();
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                student_list.DisplayAllStudent();
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.Clear();
                                Console.Write("Enter a  Name: ");
                                String name = Console.ReadLine();
                                student_list.SearchStudentByName(name);
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.Clear();
                                Console.Write("Enter   ID: ");
                                String id = Console.ReadLine();
                                student_list.SearchStudentByName(id);
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.Clear();
                                Console.Write("Enter ID: ");
                                String id_1 = Console.ReadLine();
                                student_list.RemoveStudent(id_1);
                                Console.ReadKey();
                                break;
                            case 6:
                                Console.Clear();
                                Console.Write("Enter ID: ");
                                String id_2 = Console.ReadLine();
                                student_list.UpdateStudent(id_2);
                                Console.ReadKey();
                                break;
                            case 0:
                                break;
                            default:
                                break;
                        }
                    } while (option != 0);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid number. Please write option");
                }
            }
        }
    }
}
        