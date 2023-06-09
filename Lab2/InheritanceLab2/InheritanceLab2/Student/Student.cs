﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab2
{
    internal class Student:Person
    {
        public int studentid;
        public float average;

        public Student(string name, string gender, string dob, string address,int studentid,float average)
            :base(name,gender,dob,address)
        {
            studentid = studentid;
            average = average;
        }

        public Student()
        {
        }

        public override void Inputinfo()
        {
            Console.WriteLine("Input id here:");
            studentid = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input average here:");
            average = float.Parse(Console.ReadLine());
            base.Inputinfo();
        }
        public override void Displayinfo()
        {
            Console.WriteLine("------------Student INFO---------------");
            Console.WriteLine("\n - Name: " + name);
            Console.WriteLine("\n - Gender: " + gender);
            Console.WriteLine("\n - Date of Birth: " + dob);
            Console.WriteLine("\n - Address: " + address);
            Console.WriteLine("\n - Student ID: " + studentid);
            Console.WriteLine("\n - Average: " + average);
            Console.WriteLine("----------------------------------------");
        }

    }
}
