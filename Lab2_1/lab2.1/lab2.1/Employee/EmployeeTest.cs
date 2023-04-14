using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._1.Employee
{
    internal class EmployeeTest
    {
        static void Main(string[] args)
        {
            EmployeeManage menu = new EmployeeManage();
 

            int choices;

            while (true)
            {
                try
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("============ Employee Management ===========");
                        Console.WriteLine("\n   1.Add ");
                        Console.WriteLine("\n   2.Show All Employee ");
                        Console.WriteLine("\n   3.Show Part Time Employee");
                        Console.WriteLine("\n   4.Find Employee by Id ");
                        Console.WriteLine("\n   5.Exit ");
                        Console.WriteLine("===========================================");
                        Console.WriteLine("\n Please Input the number.");
                        choices = Convert.ToInt32(Console.ReadLine());
                        switch (choices)
                        {
                            case 1:
                                Console.Clear();
                                menu.addEmployee();
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                menu.showEmployee();
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.Clear();
                                menu.show_PartTime_Employee();
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Enter Id: ");
                                string id = Console.ReadLine();
                                menu.SeachID(id);
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.WriteLine("Back to Main Menu");
                                Console.Clear();
                                return;
                            default:
                                break;
                        }
                    } while (choices != 0);
                    break;

                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number, please try again.");
                }
            }
        }
    }
}
