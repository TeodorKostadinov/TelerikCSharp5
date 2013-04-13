using System;

    class BiggestOfThreeIntegers
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());

            if (firstInt >= secondInt && firstInt >= thirdInt)
                Console.WriteLine("{0} is the biggest",firstInt);
            else
            {
                if(secondInt >=firstInt&&secondInt>=thirdInt)
                    Console.WriteLine("{0} is the biggest", secondInt);
                else
                    Console.WriteLine("{0} is the biggest", thirdInt);

                    
            }
        }
    }

