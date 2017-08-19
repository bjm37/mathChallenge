using System;
using System.Collections.Generic;


namespace mathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //request the first number of the user
            Console.WriteLine("Welcome to the math challenge! Please type any four-digit number below:");
            String numOneInput = Console.ReadLine();

            //integer validation
            while (!Int32.TryParse(numOneInput, out int numberOne))
            {
                Console.WriteLine("Not a valid four-digit number, try again.");

                numOneInput = Console.ReadLine();
            }

            //request the second number of the user
            Console.WriteLine("Thanks! Now, please type a second four-digit number of choice below:");
            String numTwoInput = Console.ReadLine();

            //integer validation
            while (!Int32.TryParse(numTwoInput, out int numberTwo))
            {
                Console.WriteLine("Not a valid four-digit number, try again.");

                numTwoInput = Console.ReadLine();
            }
        }
        //declaring task method
        public int[] SumTotal(int numberOne, int numberTwo)
        {
            var firstArray = new Stack<int>();

            for (; numberOne > 0; numberOne /= 10)
                firstArray.Push(numberOne % 10);

            return firstArray.ToArray();
        }
    }
}
