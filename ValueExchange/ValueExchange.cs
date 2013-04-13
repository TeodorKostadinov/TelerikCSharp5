using System;

    class ValueExchange
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            if (firstInt > secondInt)
            {
                int swap;
                swap = firstInt;
                firstInt = secondInt;
                secondInt = swap;
            }
            Console.WriteLine("After the examination the first number is now {0} and the second is {1}",firstInt,secondInt);
        }
    }

