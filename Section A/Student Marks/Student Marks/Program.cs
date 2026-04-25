using System;

namespace StudentMarksApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== STUDENT RESULTS SYSTEM =====\n");

            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            double mark1 = GetMark("Enter Subject 1 mark: ");
            double mark2 = GetMark("Enter Subject 2 mark: ");
            double mark3 = GetMark("Enter Subject 3 mark: ");

            double total = mark1 + mark2 + mark3;
            double average = total / 3;

            string result = average >= 50 ? "PASS" : "FAIL";

            Console.WriteLine("\n===== STUDENT REPORT =====");
            Console.WriteLine($"Student Name : {studentName}");
            Console.WriteLine($"Subject 1    : {mark1}");
            Console.WriteLine($"Subject 2    : {mark2}");
            Console.WriteLine($"Subject 3    : {mark3}");
            Console.WriteLine($"Total Marks  : {total}");
            Console.WriteLine($"Average      : {average:F2}");
            Console.WriteLine($"Result       : {result}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static double GetMark(string message)
        {
            double mark;

            while (true)
            {
                Console.Write(message);

                if (double.TryParse(Console.ReadLine(), out mark))
                {
                    return mark;
                }

                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }
    }
}