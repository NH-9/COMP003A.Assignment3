using System;

namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Driving Readiness Evaluation---");

            Console.WriteLine($"\nCurrent Year: {DateTime.Now.Year}");
            Console.Write("Enter your birth year: ");
            int inputBirth = int.Parse(Console.ReadLine());

            int age = DateTime.Now.Year - inputBirth;
            string ageStatus = "";
            if (age < 16)
            {
                ageStatus = "Not Allowed";
            }
            else if (age >= 16 && age < 18)
            {
                ageStatus = "Allowed Under Supervision";
            }
            else
            {
                ageStatus = "Allowed";
            }
            Console.WriteLine($"\nCalculated Age: {age}\nAble To Drive: {ageStatus}");
        }
    }
}
