using System;


namespace mathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the math challenge! Please type any three-digit number below:");  //request the first number of the user
            String firstInput = Console.ReadLine();
            Int32 num1 = Convert.ToInt32(firstInput);

            while (!Int32.TryParse(firstInput, out int firstOutput))  //integer validation
            {
                Console.WriteLine("Not a valid three-digit number, try again.");
            }

            Console.WriteLine("Thanks! Now, please type a second three-digit number of choice below:");  //request the second number of the user
            String secondInput = Console.ReadLine();
            Int32 num2 = Convert.ToInt32(secondInput);

            while (!Int32.TryParse(secondInput, out int secondOutput)) //integer validation
            {
                Console.WriteLine("Not a valid three-digit number, try again.");
            }

            // assigning each digit in the six slots a variable
            int dig1num1 = 0;
            int dig1num2 = 0;
            int dig1num3 = 0;

            int dig2num1 = 0;
            int dig2num2 = 0;
            int dig2num3 = 0;

            //Splitting each number into individual integers
            dig1num1 = (num1 % 10);
            dig1num2 = (num1 / 10);
            dig1num3 = (num1 / 100);

            dig2num1 = (num1 % 10);
            dig2num2 = (num1 / 10);
            dig2num3 = (num1 / 100);





        }
    }
}
