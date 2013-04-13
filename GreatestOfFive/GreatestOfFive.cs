using System;

    class GreatestOfFive
    {
        static void Main(string[] args)
        {
            double[] arr = new double[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }
            double biggest = arr[0];
            for (int i = 0; i < 5; i++)
            {
                if (biggest < arr[i])
                    biggest = arr[i];
            }
            Console.WriteLine("The biggest number is {0}",biggest);
        }
    }

