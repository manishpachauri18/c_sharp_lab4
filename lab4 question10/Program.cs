using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//. Create an enum with flags to represent the permission levels (Read, Write, Execute) of a file,
//and demonstrate how to combine these permissions for a user.
[Flags]
public enum permission { read=1,
        write=2,
        Execute=4
}

namespace lab4_question10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the which domain you belong as (user,admin,authority) ");
            string input=Console.ReadLine().ToLower();
            switch(input)
            {
                case "user":
                    permission us =permission.read;
                    Console.WriteLine($"you only have {us} permission of file :  ");
                    break;
                    case "admin":
                    permission ad = permission.read | permission.write;
                    Console.WriteLine($"you  have {ad} permission of file :  ");
                    break;
                case "authority":
                    permission aut = (permission)7;
                    Console.WriteLine($"you only have {aut} permission of file :  ");
                    break;
            }
        }
    }
}
