using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Resident> residents = new List<Resident>();
        UtilitiesManager manager = new UtilitiesManager();

        Console.Write("Enter number of residents: ");
        int resCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < resCount; i++)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Account Number: ");
            string acc = Console.ReadLine();

            Console.Write("Monthly Usage: ");
            double usage = double.Parse(Console.ReadLine());

            residents.Add(new Resident(name, address, acc, usage));
        }

        Console.Write("\nEnter number of service requests: ");
        int reqCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < reqCount; i++)
        {
            Console.WriteLine("Select resident index:");
            for (int j = 0; j < residents.Count; j++)
            {
                Console.WriteLine($"{j}: {residents[j].Name}");
            }

            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= residents.Count)
            {
                Console.WriteLine("Invalid resident index!");
                i--; // retry same loop
                continue;
            }

            Console.Write("Request Type: ");
            string type = Console.ReadLine();

            Console.Write("Priority (1-5): ");
            int priority = int.Parse(Console.ReadLine());

            Console.Write("Severity (1-10): ");
            int severity = int.Parse(Console.ReadLine());

            Console.Write("Estimated Hours: ");
            int hours = int.Parse(Console.ReadLine());

            manager.Requests.Add(new ServiceRequest(residents[index], type, priority, severity, hours));
        }

        while (manager.Requests.Count > 0)
        {
            manager.DisplayQueue();

            Console.Write("Select request index to process: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice < 0 || choice >= manager.Requests.Count)
            {
                Console.WriteLine("Invalid index. Try again.");
                continue;
            }

            manager.ProcessRequest(choice);
        }

        manager.ShowSummary();
    }
}