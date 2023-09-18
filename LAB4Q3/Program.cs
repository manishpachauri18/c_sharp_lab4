using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4Q3
{
    internal class Person
    {
        private string fname;
        private string lname;
        private string fullname;
        public string FNAME
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }
        public string LNAME
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }
        public string FULLNAME
        {
            get
            {
                return fullname.ToUpper();
            }
            set
            {
                fullname = value;
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FNAME = Console.ReadLine();
            p.LNAME = Console.ReadLine();
            p.FULLNAME = p.fname + " "+p.lname;
            Console.WriteLine(p.FULLNAME);
            Console.ReadLine();
        }
    }
}
