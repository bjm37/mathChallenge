using System;

namespace mathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //request the first number of the user
            Console.WriteLine("Welcome to the math challenge! Please type any four-digit number below:"); 
            int numberOne;
            String numOneInput = Console.ReadLine();
           
            //integer validation
            while (!Int32.TryParse(numOneInput, out numberOne))
            {
                Console.WriteLine("Not a valid four-digit number, try again.");

                numOneInput = Console.ReadLine();
            }

            //request the second number of the user
            Console.WriteLine("Thanks! Now, please type a second four-digit number of choice below:"); 
            int numberTwo;
            String numTwoInput = Console.ReadLine();
            
            //integer validation
            while (!Int32.TryParse(numTwoInput, out numberTwo))
            {
                Console.WriteLine("Not a valid four-digit number, try again.");

                numTwoInput = Console.ReadLine();
            }
        }
    }
}
