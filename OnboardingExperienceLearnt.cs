using System;


namespace OnboardingExperience
{
    public class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            var question = ("Please input your first name: ");
            var answer = AskQuestion(question);
            user.FirstName = answer;

            user.LastName = AskQuestion("Please input your last name: ");
            Console.WriteLine("Well hi there, " + user.FirstName + user.LastName + ". Almost done here.");

            user.IsAccountowner = AskBoolQuestion("Are you the account owner?");
            Console.WriteLine("Alright cool, You are account owner: " + user.FirstName);

            
            user.AskPinNumber = AskPinNumber("What is your 4-digit pin? ", 4)};
            Console.WriteLine("Awesome! You entered: " + user.AskPinNumber);

            Console.ReadLine();

        }

        public static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            var answer = Console.ReadLine();

            return answer;


        }

        static bool AskBoolQuestion(string question)
        {
            var hasAnswered = false;
            var responseBool = false;

            while (!hasAnswered)
            {
                var response = AskQuestion(question + " (yazz/nah)");

                if (response == "y")
                {
                    responseBool = true;
                    hasAnswered = true;
                }
                else if (response == "nah")
                {
                    responseBool = false;
                    hasAnswered = true;
                }
            }

            return responseBool;
        }

    }
}
