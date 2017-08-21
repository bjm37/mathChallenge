using System;





namespace mathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //request the first number of the user 
            Console.WriteLine("Welcome to the true or false math challenge! Your goal today will be to enter two numbers, and check if each corresponding place in the two numbers sums to the same total.");
            Console.WriteLine("Please type any three-digit number below:");
            String firstInput = Console.ReadLine();

            while (firstInput.Length != 3 || !Int32.TryParse(firstInput, out int firstOutput))  //integer validation
            {
                Console.WriteLine("Not a valid three-digit number, try again.");
                firstInput = Console.ReadLine();
            }
            int num1 = Convert.ToInt32(firstInput);

            //request the second number of the user
            Console.WriteLine("Thanks! Now, please type a second three-digit number of choice below:");
            String secondInput = Console.ReadLine();

            while (secondInput.Length != 3 || !Int32.TryParse(secondInput, out int secondOutput)) //integer validation
            {
                Console.WriteLine("Not a valid three-digit number, try again.");
                secondInput = Console.ReadLine();
            }
            int num2 = Convert.ToInt32(secondInput);

            // assigning each digit in the six slots a variable
            int dig1num1, dig2num1, dig3num1 = 0;
            int dig1num2, dig2num2, dig3num2 = 0;

            //Splitting each number into individual integers
            dig1num1 = (num1 % 10);
            dig2num1 = (num1 / 10) % 10;
            dig3num1 = (num1 / 100);

            dig1num2 = (num2 % 10);
            dig2num2 = (num2 / 10) % 10;
            dig3num2 = (num2 / 100);

            //Writing the new integers to the console
            Console.WriteLine("Individual digits for your first number: {1}, {2}, {3}", num1, dig3num1, dig2num1, dig1num1);
            //Console.ReadKey();

            Console.WriteLine("Individual digits for your second number: {1}, {2}, {3}", num2, dig3num2, dig2num2, dig1num2);
            //Console.ReadKey();

            // constructing comparison aka addition variables
            int total1 = 0;
            int total2 = 0;
            int total3 = 0;

            //combining corresponding numbers
            total1 = (dig3num1 + dig3num2);
            total2 = (dig2num1 + dig2num2);
            total3 = (dig1num1 + dig1num2);

            //boolean condition to test whether the corresponding numbers are equal
            bool a = (total1 == total2 && total2 == total3);

            Console.WriteLine("True or False? The result of adding those corresponding numbers is (" + total1 + "," + total2 + "," + total3 + ") which is " + a);
        }
    }
}