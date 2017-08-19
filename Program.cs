using System;
using System.Collections.Generic;


namespace mathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the math challenge! Please type any four-digit number below:");  //request the first number of the user
            String firstInput = Console.ReadLine();

            while (!Int32.TryParse(firstInput, out int num1))  //integer validation
            {
                Console.WriteLine("Not a valid four-digit number, try again.");
                firstInput = Console.ReadLine();
            }


            Console.WriteLine("Thanks! Now, please type a second four-digit number of choice below:");  //request the second number of the user
            String secondInput = Console.ReadLine();

            while (!Int32.TryParse(secondInput, out int num2)) //integer validation
            {
                Console.WriteLine("Not a valid four-digit number, try again.");
                secondInput = Console.ReadLine();
            }

            //Convert.ToInt32(firstInput);
            //Convert.ToInt32(secondInput);

            //declaring task method
           static void SumTotal()
            {
                var firstArray = new Stack<int>();

                for (; firstInput > 0; firstInput /= 10)
                    firstArray.Push(firstInput % 10);

                return firstArray.ToArray();

                var secondArray = new Stack<int>();

                for (; numberTwo > 0; numberTwo /= 10)
                    secondArray.Push(numberTwo % 10);

                return secondArray.ToArray();
            }
        }
    }
}
