using System;

namespace mathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the math challenge! Please type any four-digit number below:"); //request the first number of the user

            int numberOne;

            String numOneInput = Console.ReadLine();

            while (!Int32.TryParse(numOneInput, out numberOne))
            {
                Console.WriteLine("Not a valid number, try again.");

                numOneInput = Console.ReadLine();
            }

            Console.WriteLine("Thanks! Now, please type a second four-digit number of choice below:"); //request the second number of the user
            int numberTwo;

            String numTwoInput = Console.ReadLine();

            while (!Int32.TryParse(numTwoInput, out numberTwo))
            {
                Console.WriteLine("Not a valid number, try again.");

                numTwoInput = Console.ReadLine();
            }
        }
    }
}
