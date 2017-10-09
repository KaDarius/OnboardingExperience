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
            string firstName
            string lastName
            string accOwner;
            int pin;
            bool own = false;
            Console.WriteLine("Please input your Username: " );
            firstName = Console.ReadLine();
            Console.WriteLine("Please input your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Are you the account owner?: ");
            accOwner = Console.ReadLine();
            Console.Write("Please enter you PIN: ");
            pin = Console.Read();

            {
                if (accOwner == "yes")
                {
                    own == true;
                }
                {
                    return true;
                }

                else
                //brings back a true if yes? 
                own == false;

                {
                    return false;

                }
            }
        }
    }
}
