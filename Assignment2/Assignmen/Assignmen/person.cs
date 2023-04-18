using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmen
{
    internal class person
    {
        string _name;
         int _age;
        string _dob;
        string _address;


        public string p_name 
        {
                get { return _name; }
                set { _name = value; }
            
        }

        public int  p_age
        {
            get { return _age; }
            set { _age = value; }

        }
        public string p_dob
        {
            get { return _dob; }
            set { _dob = value; }

        }
        public string p_address
        {
            get { return _address; }
            set { _address = value; }

        }

        public void input_info()
        {
            Console.WriteLine();
            Console.ReadLine();
        }

        public void display_info()
        {
            Console.WriteLine();
            Console.ReadLine();
        }
      
    }
}
