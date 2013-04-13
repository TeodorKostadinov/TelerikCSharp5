using System;

    class SortRealNums
    {
        static void Main(string[] args)
        {
            double realOne = double.Parse(Console.ReadLine());
            double realTwo = double.Parse(Console.ReadLine());
            double realThree = double.Parse(Console.ReadLine());
            if (realOne < realTwo)
            {

                if (realTwo < realThree)
                {
                    Console.WriteLine("The numbers in decending order are {0},{1},{2}", realThree, realTwo, realOne);
                }
                else
                {
                    if (realOne < realThree)
                        Console.WriteLine("The numbers in decending order are {0},{1},{2}", realTwo, realThree, realOne);
                    else
                        Console.WriteLine("The numbers in decending order are {0},{1},{2}", realTwo, realOne, realThree);

                }
            }
            else
            {
                if (realTwo > realThree)
                {
                    Console.WriteLine("The numbers in decending order are {0},{1},{2}", realOne, realTwo, realThree);

                }
                else
                {
                    if(realOne>realThree)
                        Console.WriteLine("The numbers in decending order are {0},{1},{2}", realOne, realThree, realTwo);
                    else
                        Console.WriteLine("The numbers in decending order are {0},{1},{2}", realThree,realOne, realTwo);

                }
            }
        }
    }

