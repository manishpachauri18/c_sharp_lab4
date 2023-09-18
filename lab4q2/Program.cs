using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4q2
{
    internal class CAR
    {
        public string make;
        public string model;
        public int year;
        public string carname;
        public string MAKE
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }
        public string MODEL
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public int YEAR
        {
            get
            {
                return year;
            }
            set
            {
                year=value;
            }
        }
        public string CARNAME
        {
            get
            {
                return make + " " + model+" "+year;
            }
           set
            {
                carname= value;
            }
        }

        
        static void Main(string[] args)
        {
            CAR car=new CAR();
            car.MAKE = "MAHINDRA";
            car.MODEL = "THAR";
            car.YEAR = 2023;
            car.CARNAME =car.make+" "+car.model+" "+car.year;
            Console.WriteLine(car.carname);
            Console.ReadKey();
            
        }
    }
}
