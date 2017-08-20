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
            Int32 num1 = Convert.ToInt32(firstInput);

            while (!Int32.TryParse(firstInput, out int secondOutput))  //integer validation
            {
                Console.WriteLine("Not a valid four-digit number, try again.");
                num1 = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Thanks! Now, please type a second four-digit number of choice below:");  //request the second number of the user
            String secondInput = Console.ReadLine();
            Int32 num2 = Convert.ToInt32(secondInput);

            while (!Int32.TryParse(secondInput, out int secondOutput)) //integer validation
            {
                Console.WriteLine("Not a valid four-digit number, try again.");
                num2 = Convert.ToInt32(Console.ReadLine());
            }

        }
        //declaring task method
        public int[] NumbersIn(int num1, int num2)
        {
            var firstArray = new Stack<int>(); //creating an array for the first number

            for (; num1 > 0; num1 /= 10)
                firstArray.Push(num1 % 10);

            return firstArray.ToArray();

            var secondArray = new Stack<int>(); ////creating an array for the second number

            for (; num2 > 0; num2 /= 10)
                secondArray.Push(num2 % 10);

            return secondArray.ToArray();


            //Parsing the numbers
            int total1 = 0;
            int total2 = 0;

            for (i in firstArray; i < firstArray.length; i++)
            {
                total1 += i;
            }
            for (i in secondArray; i < secondArray.length; i++)
            {
                total2 += i;
            }

            if (total1 == total2)
            {
                return true;
           else {
                    return false;
                }

            }

        }
    }
