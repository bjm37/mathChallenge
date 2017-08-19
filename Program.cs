using System;


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

            int[] firstArray = new int[4];  //creating an array for the first number
            for (; num1 > 0; num1 /= 10)
                firstArray.(num1 % 10);
            Console.WriteLine(firstArray);

            int[] secondArray = new int[4]; //creating an array for the second number
            for (; num2 > 0; num2 /= 10)
                secondArray.(num2 % 10);
            Console.WriteLine(secondArray);

            /* public Stack<int> NumbersIn(int numberOne) Start a new method???*/
            {
                //complete the task here?
            }

        }
    }
}
