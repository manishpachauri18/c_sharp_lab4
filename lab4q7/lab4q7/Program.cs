using System;
using System.Collections.Generic;

namespace lab4q7
{
   
    internal class Program
    {
        private string bookshelf;
        public string this[string key] 
        { 
            
            get 
            
            {
                return bookshelf;

            }
            set
            {
                if(key=="title")
                {

                    bookshelf = value;
                }
                else
                {
                    throw new Exception("enter a valid title");
                }
            }
        }
        static void Main(string[] args)
        {
          
           Program p =new Program();
            p["title"] = "manish";
            Console.WriteLine(p["title"]);
        }
    }
}
