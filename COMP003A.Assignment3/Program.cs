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

            Console.Write("\nDo you have a valid Learner's Permit? (yes/no): "); //optional rule: can only grant conditional readiness
            bool inputPermit = Console.ReadLine() == "yes";
            Console.Write("Do you have a valid Driver's License? (yes/no): "); //mandatory rule: neccesary to be granted full readiness
            bool inputLicense = Console.ReadLine() == "yes";

            string noReady = "Not Ready (you may not operate a vehicle)";
            string someReady = "Conditionally Ready (you may operate a vehicle under the supervision of a licensed driver aged 25 or older)";
            string fullReady = "Ready (you may operate a vehicle alone)";
            string readyStatus = "";

            if (ageStatus == "Allowed Under Supervision")
            {
                if (inputLicense || inputPermit)
                {
                    readyStatus = someReady;
                }
                else
                {
                    readyStatus = noReady;
                }
            }
            else if (ageStatus == "Allowed")
            {
                if (inputLicense)
                {
                    readyStatus = fullReady;
                }
                else if (inputPermit)
                {
                    readyStatus = someReady;
                }
                else
                {
                    readyStatus = noReady;
                }
            }
            else
            {
                readyStatus = noReady;
            }
            Console.WriteLine($"\nReadiness Status: {readyStatus}");

            Console.WriteLine("\nSelect a guidance option:");
            switch (readyStatus)
            {
                case "Ready (you may operate a vehicle alone)":
                    Console.WriteLine("RDL - Review Driving Laws\nRAV - Register a Vehicle\nPIN - Purchase Insurance");
                    break;

                case "Conditionally Ready (you may operate a vehicle under the supervision of a licensed driver aged 25 or older)":
                    Console.WriteLine("RDL - Review Driving Laws\nTBT - Take Behind-The-Wheel Test\nPDS - Practice Driving Skills");
                    break;

                case "Not Ready (you may not operate a vehicle)":
                    Console.WriteLine("LDL - Learn Driving Laws\nTPT - Take Practice Test\nTLT - Take Driving Laws Test");
                    break;
            }
            Console.Write("Enter Choice: ");
            string inputGuidance = Console.ReadLine();

            Console.WriteLine("\nGuidance:");
            switch (inputGuidance)
            {
                case "RDL":
                    Console.WriteLine("Refresh your memory on the rules of the road.");
                    break;

                case "RAV":
                    Console.WriteLine("Follow documented steps to register a vehicle at your local DMV.");
                    break;

                case "PIN":
                    Console.WriteLine("You must have an insured vehicle to drive; research what insurance plan will work best for you.");
                    break;

                case "TBT":
                    Console.WriteLine("Schedule a behind-the-wheel exam at your local DMV to obtain a driver's license.");
                    break;

                case "PDS":
                    Console.WriteLine("Find a safe area to practice your driving skills, such as an empty parking lot.");
                    break;

                case "LDL":
                    Console.WriteLine("Read and memorize official driving law documenation.");
                    break;

                case "TPT":
                    Console.WriteLine("Take the pratice multiple-choice test on the DMV website to test your knowledge");
                    break;

                case "TLT":
                    Console.WriteLine("Schedule a multiple-choice exam on driving laws at your local DMV to obtain a learner's permit.");
                    break;
            }
        }
    }
}
