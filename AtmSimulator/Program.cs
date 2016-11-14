using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ATM Simulator.");

            //set first balance 1000
            decimal balance = 1000;
            bool stop = false;
            while (!stop)
            {
                Console.WriteLine();

                Console.WriteLine("SELECT MENU:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdrawal");
                Console.WriteLine("x. Exit Transaction");

                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        Console.WriteLine("1. Check Balance");
                        Console.WriteLine("Saldo: " + balance);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("2. Deposit");

                        Console.WriteLine("input amount for deposit:");
                        string d_amount = Console.ReadLine();
                        balance = balance + decimal.Parse(d_amount);

                        Console.WriteLine("Saldo: " + balance);
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("3. Withdrawal");

                        Console.WriteLine("input amount for withdrawal:");
                        string w_amount = Console.ReadLine();
                        balance = balance - decimal.Parse(w_amount);

                        Console.WriteLine("Saldo: " + balance);
                        Console.ReadKey();
                        break;
                    case "x":
                        stop = true;
                        break;
                }
            }

            Console.WriteLine("Transaction is done.");
            Console.ReadKey();
        }
    }
}
