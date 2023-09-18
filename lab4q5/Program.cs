using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4q5
{
    internal class Program
    {
        private int[] list =new int[10];
        public int this[int index]
        {
            get
            {  return list[index]; }
            set { list[index] = value; }
        
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program[0] = 1;
            program[1] = 2;
            program[2] = 3;
            program[3] = 4;
            program[4] = 5;
            Console.WriteLine(program[0]);
            Console.WriteLine(program[1]);
        }

    }
}
