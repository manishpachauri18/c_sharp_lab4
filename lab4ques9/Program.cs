using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Implement an enum to represent different geometric shapes (e.g., Circle, Square, Triangle) and use
//it to calculate the area of a specific shape.
public enum shapes { circle,square,tringle}
namespace lab4ques9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the shape (e.g., Circle, Square, Triangle) which area you want to calculat :: ");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "circle":
                    Console.WriteLine("you need to give radius of  circle");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    double area= 3.14*radius*radius;
                    Console.WriteLine($"the area of {shapes.circle} is = {area}");
                    break;

                case "tringle":
                    Console.WriteLine("you need to give length of  tringle");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("you need to give height of  tringle");
                    double height = Convert.ToDouble(Console.ReadLine());
                    double area1 = 0.5*length*height;
                    Console.WriteLine($"the area of  {shapes.tringle} is = {area1}");
                    break;
                case "square":
                    Console.WriteLine("you need to give measure  a side  of  square");
                    double side = Convert.ToDouble(Console.ReadLine());
                    double area2 = side*side;
                    Console.WriteLine($"the area of  {shapes.square} is = {area2}");
                    break;
                default:
                    Console.WriteLine("not a valid shape :");
                    break;

            }
        }
    }
}
