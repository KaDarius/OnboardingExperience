using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingExperience
{
    public class Program
    {
        static void Main(string[] args)
        {
            var name = "firstName";
            var name2 = "lastName";
            var isOwner = "accOwner";
            int pin;
            bool accOwner = false;
            Console.WriteLine("Please input your first name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please input your last name: ");
            name2 = Console.ReadLine();
            Console.WriteLine("Well hi there, "+name+ name2+ ". Almost done here.");
            Console.WriteLine("Are you the account owner?: ");
            isOwner = Console.ReadLine();
            Console.Write("Please enter you PIN: ");
            pin = Console.Read();
            {
                if (isOwner == "yes")
                {
                 Console.WriteLine("Great "+ name + " , you are logged in.");
                }

                else (isOwner== "no")
                {
                    Console.WriteLine("Drats, I can't let you in.");
                }
            }
        }


    }
}