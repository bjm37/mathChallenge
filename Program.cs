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
        }
        //declaring task method
        public int[] NumbersIn(int numberOne)
        {
            var firstArray = new Stack<int>();

            for (; numberOne > 0; numberOne /= 10)
                firstArray.Push(numberOne % 10);

            return firstArray.ToArray();
        }
        /* public Stack<int> NumbersIn(int numberOne)
         {
             if (numberOne == 0) return new Stack<int>();

             var firstArray = NumbersIn(numberOne / 10);

             firstArray.Push(numberOne % 10);

             return firstArray.ToArray;
          }*/
    }
}
