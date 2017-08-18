using System;

namespace mathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the math challenge! Please type any four-digit number below:");
            var number1 = Console.ReadLine();

            Console.WriteLine("Thanks! Now, please type a second four-digit number of choice below:");
            var number2 = Console.ReadLine();

            Convert.ToInt32(number1);
            Convert.ToInt32(number2);


            //perform the task with a new method. This will include converting the strings to integers
        }
        public void Task()
        {

        }
    }
}
