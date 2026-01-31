using System;
using System.ComponentModel.DataAnnotations;

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

            Console.Write("\nDo you have a valid Learner's Permit? (yes/no): ");
            bool inputPermit = Console.ReadLine() == "yes";
            Console.Write("Do you have a valid Driver's License? (yes/no): ");
            bool inputLicense = Console.ReadLine() == "yes";

            string readyStatus = "";
            if (ageStatus == "Allowed Under Supervision")
            {
                if (inputLicense ||  inputPermit)
                {
                    readyStatus = "Conditionally Ready";
                }
                else
                {
                    readyStatus = "Not Ready";
                }
            }
            else if (ageStatus == "Allowed")
            {
                if (inputLicense)
                {
                    readyStatus = "Ready";
                }
                else if (inputPermit)
                {
                    readyStatus = "Conditionally Ready";
                }
                else
                {
                    readyStatus = "Not Ready";
                }
            }
            else
            {
                readyStatus = "Not Ready";
            }
            Console.WriteLine($"\nReadiness Status: {readyStatus}");
        }
    }
}
