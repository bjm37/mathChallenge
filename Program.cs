using System;





namespace mathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //request the first number of the user 
            Console.WriteLine("Welcome to the math challenge! Please type any three-digit number below:");
            String firstInput = Console.ReadLine();

            while (firstInput.Length != 3 || !Int32.TryParse(firstInput, out int firstOutput))  //integer validation
            {
                Console.WriteLine("Not a valid three-digit number, try again.");
                firstInput = Console.ReadLine();
            }
            //int num1 = Convert.ToInt32(firstInput);

            //request the second number of the user
            Console.WriteLine("Thanks! Now, please type a second three-digit number of choice below:");
            String secondInput = Console.ReadLine();

            while (secondInput.Length != 3 || !Int32.TryParse(secondInput, out int secondOutput)) //integer validation
            {
                Console.WriteLine("Not a valid three-digit number, try again.");
                secondInput = Console.ReadLine();
            }
            //int num2 = Convert.ToInt32(secondInput);

            // assigning each digit in the six slots a variable
            var firstInputCharArray = firstInput.ToCharArray();
            var secondInputCharArray = secondInput.ToCharArray();
            int[] totals = new int[3];
            for (int i = 0; i < firstInputCharArray.Length; ++i)
            {
                totals[i] = AddDigits(firstInputCharArray[i], secondInputCharArray[i]);
            }

            int temp = totals[0];
            bool result = true;
            for (int i = 1; i < firstInputCharArray.Length; ++i)
            {
                bool comparisonResult = (temp == totals[i]);
                result = result && comparisonResult;
            }
            Console.WriteLine(result);


        }

        private static int AddDigits(char firstStringChar, char secondStringChar)
        {
            var int1 = Convert.ToInt32(firstStringChar);
            var int2 = Convert.ToInt32(secondStringChar);
            return int1 + int2;



        }
    }
}
