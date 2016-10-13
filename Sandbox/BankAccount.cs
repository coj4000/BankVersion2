using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public class BankAccount
    {
        private double balance;

        public BankAccount()
        {
            balance = 0;
        }

        public void Deposit(double amount)
        {
            if (amount >= 0)
            {
                balance = balance + amount;
            }
            else
            {
                Console.WriteLine("Det kan du ikke");
            }
          
        }

        public void Withdraw(double amount)
        {
            if (amount >= 0)
            {
                if (balance <= 0)
                {
                    Console.WriteLine("Det kan du ikke");
                }
                else
                {
                    if (amount <= balance)
                    {
                        balance = balance - amount;
                    }
                    else
                    {
                        Console.WriteLine("Det kan du ikke");
                    }

                }
            }
            else
            {
                Console.WriteLine("Det kan du ikke");
            }
            
            
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
