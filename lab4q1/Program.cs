using System;
namespace lab4q1
{
    class BANK
    {
        public double balance;
     
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if(value<=0)
                {
                    Console.WriteLine("your balance is going to negative :");
                }
                else
                {
                    balance = value;
                }
            }
        }
        public static void Main(string[] args)
        {
            BANK bank = new BANK();
            bank.Balance = 0;
            Console.WriteLine(bank.Balance);
            
        }

    }
}