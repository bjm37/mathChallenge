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
            int dig2num1 = 0;
            int dig3num1 = 0;

            int dig1num2 = 0;
            int dig2num2 = 0;
            int dig3num2 = 0;

            //Splitting each number into individual integers
            dig1num1 = (num1 % 10);
            dig2num1 = (num1 / 10) % 10;
            dig3num1 = (num1 / 100);

            dig1num2 = (num2 % 10);
            dig2num2 = (num2 / 10) % 10;
            dig3num2 = (num2 / 100);

            //Writing the new integers to the console
            Console.WriteLine("Press enter to get individual digits for your first number");
            Console.WriteLine("{0}->{1}, {2}, {3}", num1, dig3num1, dig2num1, dig1num1);
            Console.ReadKey();

            Console.WriteLine("Press enter to get individual digits for your second number");
            Console.WriteLine("{0}->{1}, {2}, {3}", num2, dig3num2, dig2num2, dig1num2);
            Console.ReadKey();

            // constructing comparison aka addition variables
            int total1 = 0;
            int total2 = 0;
            int total3 = 0;

            //combining corresponding numbers
            total1 = (dig1num2 + dig1num2);
            total2 = (dig2num1 + dig2num2);
            total3 = (dig3num1 + dig3num2);

            //boolean condition to test whether the corresponding numbers are equal
            bool a = (total1 == total2 && total2 == total3);
            bool b = (total1 != total2 && total2 == total3);
            bool c = (total1 == total2 && total2 != total3);

            if (a)
            {
                Console.WriteLine("True");
                //Console.ReadLine();
            }

            if (b)
            {
                Console.WriteLine("False");
                //Console.ReadLine();
            }

            if (c)
            {
                Console.WriteLine("False");
                //Console.ReadLine();
            }

        }
    }
}
