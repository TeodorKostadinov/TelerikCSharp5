 using System;

    class InputTypeOfYourChoise
    {
        static void Main(string[] args)
        {
            int ifInt;
            double ifDouble;
            string input = Console.ReadLine();
            byte option = 0;
            if (int.TryParse(input,out ifInt)==true)
            {
                option=1;
            }
            if (double.TryParse(input, out ifDouble) == true)
            {
                option=2;
            }
            
            switch (option)
            {
                case 0: Console.WriteLine(input + "*"); break;
                case 1: ifInt++; Console.WriteLine(ifInt); break;
                case 2: ifDouble++; Console.WriteLine( ifDouble); break;
                default: Console.WriteLine("The input type is not recognized"); break;
            }
           
            
        }
    }

