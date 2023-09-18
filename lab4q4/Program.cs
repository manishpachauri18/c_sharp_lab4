using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4q4
{
    internal class temprature
    {
       public double celcius;
       public double farenhite;
        public double CELCIUS
        {
            get
            {
                return celcius;

            }
            set
            {
                Console.WriteLine("hii");
                celcius= (((value * 9) / 5) + 32);
            }
        }
       

        static void Main(string[] args)
        {
            temprature tp= new temprature();
            tp.CELCIUS = 36.5;
            Console.WriteLine(tp.celcius);
           
        }
    }
}
