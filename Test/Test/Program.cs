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
            //Student what = new Student();

            //what.InputInfo();

            //what.DisplayInfo();

            //Console.ReadKey();

            int num = 0;

            while (true)
            {
                try
                {
                    Console.Write("Input number of students: ");
                    num = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Number");
                }
            }

            Student[] nstu = new Student[num];
            for (int i = 0; i < nstu.Length; i++)
            {
                nstu[i] = new Student();
                nstu[i].InputInfo();

            }

            for (int i = 0; i < nstu.Length; i++)
            {
                nstu[i].DisplayInfo();
                Console.ReadKey();
            }
        }
    }
}
