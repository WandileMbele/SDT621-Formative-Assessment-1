using System;

namespace ATMConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 5000.00m;

            Console.WriteLine("===== ATM WITHDRAWAL SYSTEM =====");
            Console.WriteLine($"Current Balance: R{balance:F2}\n");

            Console.Write("Enter withdrawal amount: R");

            decimal withdrawal;

            while (!decimal.TryParse(Console.ReadLine(), out withdrawal) || withdrawal <= 0)
            {
                Console.Write("Invalid amount. Enter a valid withdrawal amount: R");
            }

            if (withdrawal > balance)
            {
                Console.WriteLine("\nTransaction Failed: Insufficient funds.");
            }
            else
            {
                balance -= withdrawal;

                Console.WriteLine("\n===== TRANSACTION RECEIPT =====");
                Console.WriteLine($"Withdrawal Amount : R{withdrawal:F2}");
                Console.WriteLine($"Remaining Balance : R{balance:F2}");
                Console.WriteLine($"Transaction Time  : {DateTime.Now}");
                Console.WriteLine("Status            : Successful");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}