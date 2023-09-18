using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create an enum representing the seasons and write a
//switch statement that prints a message based on the current season.
public enum seasons
{
    Spring,
    Summer,
    Autumn,
    Winter
}
namespace lab4que8
{
    public class Program
    {
      
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the current season (Spring, Summer, Autumn, or Winter): ");
            String input=Console.ReadLine().ToLower();
            Console.WriteLine(input);

            switch (input)
            {
                case "winter":
                    Console.WriteLine($"the current  season is {seasons.Winter}");
                    break;
                case "summer":

                    Console.WriteLine($"the current seasons is {seasons.Summer}"); break;
                case "spring":
                    Console.WriteLine($"the currentseason is {seasons.Spring} " ); break;
                case "autumn":
                    Console.WriteLine($"the currentseason is { seasons.Autumn} "); break;
                default:
                    Console.WriteLine("invalid season");
                    break;


            }

        }

        
    }
}
