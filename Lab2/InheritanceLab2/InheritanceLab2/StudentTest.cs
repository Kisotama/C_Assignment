using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab2
{
    internal class StudentTest
    {
         static void Main(String[] args)
        {
            Menu menu = new Menu();

            int choices;

            while(true)
            {
                try
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("============ Student Management ===========");
                        Console.WriteLine("\n   1.Add ");
                        Console.WriteLine("\n   2.Display ");
                        Console.WriteLine("\n   3.Find the highest and the lowest ");
                        Console.WriteLine("\n   4.Find students by Id ");
                        Console.WriteLine("\n   5.Find Student got Scholarship ");
                        Console.WriteLine("\n   6.Exit ");
                        Console.WriteLine("===========================================");
                        Console.WriteLine("\n Please Input the number.");
                        choices = Convert.ToInt32(Console.ReadLine());
                        switch (choices)
                        {
                            case 1:
                                Console.Clear();
                                menu.AddStudent();
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                menu.DisplayStudent();
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.Clear();
                                menu.findthehighestandthelowest();
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Enter Id: ");
                                int id = Int32.Parse(Console.ReadLine());
                                menu.find_student_id(id);
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.Clear();
                                menu.Scholarship();
                                Console.ReadKey();
                                break;
                            case 6:
                                Console.WriteLine("Exiting...");
                                return;
                            default:
                                break;
                        }
                    } while (choices != 0);
                    break;
                    
                }
                catch(Exception)
                {
                    Console.WriteLine("Invalid number, please try again.");   
                }
            }
        }
    }
}
