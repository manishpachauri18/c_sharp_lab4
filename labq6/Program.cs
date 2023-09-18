using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labq6
{
    internal class Program
    {
        private int[] stack=new int[10];
        public int this[int index]
        {
            get
            {
                return stack[((stack.Length) - index) - 1];
            }
             set
                    {
                    stack[index] = value;
                }
        }
        static void Main(string[] args)
        {
            Program p= new Program(); p[0] = 1;
            p[1] = 2;
            p[2] = 3;
            p[3] = 4;
            p[4] = 5;
            p[5] = 6;
            p[6] = 7;
            p[7] = 8;
            p[8] = 9;
            p[9] = 10;

            Console.WriteLine(p[0]);
            Console.ReadLine();
        }
    }
}
