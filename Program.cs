using System;
using System.Collections.Generic;

namespace mathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>  = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                string userValue = Console.ReadLine();
                int userInt;
                if (int.TryParse(userValue, out userInt))
                {
                    userInts.Add(userInt);
                }
            }
        }
    }
}
