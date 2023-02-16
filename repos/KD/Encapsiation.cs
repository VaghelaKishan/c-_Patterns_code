using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    class Account
    {
        int accountBalance = 1000;

        //public void setBalance(int amount)
        //{
        //    if(amount < 0)
        //    {
        //        Console.WriteLine("you not pass negative value");
        //    }
        //    else
        //    {
        //        accountBalance = amount;
        //    }
        //    accountBalance = amount;
        //}
        //public void getBalance()
        //{
        //    Console.WriteLine("your account balance is: " + accountBalance);
        //}



        // you dont use setter or getter then use c# Properties
        public int Balance
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("YOu not pass negative value");
                }
                else
                {
                    accountBalance = value;
                }

            }
            get
            {
                return accountBalance;
            }
        }
        
       
            public static void combine()
            {
                Account obj = new Account();
                //obj.accountBalance = 100;
                //obj.setBalance(-10000);
                //obj.getBalance(); 

                obj.Balance = 1000000000;
                Console.WriteLine("account Balance is: " + obj.Balance);
            }
        
    }
}