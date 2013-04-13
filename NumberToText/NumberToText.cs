using System;

    class NumberToText
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int digitCount=1;
            int inputCopy = input;
            for (int i = 0; i < 4; i++)
            {
                if (inputCopy / 10 != 0)
                { digitCount++; inputCopy = inputCopy / 10; }
            }
            
            if (digitCount <3)
            {
                if (input < 20)
                {
                    switch (input)
                    {
                        case 0: Console.WriteLine("Zero"); break;
                        case 1: Console.WriteLine("One"); break;
                        case 2: Console.WriteLine("Two"); break;
                        case 3: Console.WriteLine("Three"); break;
                        case 4: Console.WriteLine("Four"); break;
                        case 5: Console.WriteLine("Five"); break;
                        case 6: Console.WriteLine("Six"); break;
                        case 7: Console.WriteLine("Seven"); break;
                        case 8: Console.WriteLine("Eight"); break;
                        case 9: Console.WriteLine("Nine"); break;
                        case 10: Console.WriteLine("Ten"); break;
                        case 11: Console.WriteLine("Eleven"); break;
                        case 12: Console.WriteLine("Twelve"); break;
                        case 13: Console.WriteLine("Thirteen"); break;
                        case 14: Console.WriteLine("Fourteen"); break;
                        case 15: Console.WriteLine("Fifteen"); break;
                        case 16: Console.WriteLine("Sixteen"); break;
                        case 17: Console.WriteLine("Seventeen"); break;
                        case 18: Console.WriteLine("Eighteen"); break;
                        case 19: Console.WriteLine("Nineteen"); break;
                    }
                }
                else
                {
                    switch (input  / 10)
                    {
                        case 2: Console.Write("Twenty "); break;
                        case 3: Console.Write("Thirty "); break;
                        case 4: Console.Write("Fourty "); break;
                        case 5: Console.Write("Fifty "); break;
                        case 6: Console.Write("Sixty "); break;
                        case 7: Console.Write("Seventy "); break;
                        case 8: Console.Write("Eightty "); break;
                        case 9: Console.Write("Ninety "); break;
                    }
                    if (input % 10 != 0)
                    {
                        
                        switch (input%10)
                        {
                    case 1: Console.Write("one"); break;
                    case 2: Console.Write("two"); break;
                    case 3: Console.Write("three"); break;
                    case 4: Console.Write("four"); break;
                    case 5: Console.Write("five"); break;
                    case 6: Console.Write("six"); break;
                    case 7: Console.Write("seven"); break;
                    case 8: Console.Write("eight"); break;
                    case 9: Console.Write("nine"); break;
                        }
                    }
                }
            }
            if (digitCount == 3)
            {
                switch (input/100)
                {
                    case 1: Console.Write("One"); break;
                    case 2: Console.Write("Two"); break;
                    case 3: Console.Write("Three"); break;
                    case 4: Console.Write("Four"); break;
                    case 5: Console.Write("Five"); break;
                    case 6: Console.Write("Six"); break;
                    case 7: Console.Write("Seven"); break;
                    case 8: Console.Write("Eight"); break;
                    case 9: Console.Write("Nine"); break;
                }
                Console.Write(" hundred ");
                switch (input / 10%10)
                {
                    case 0: 
                    case 1:if (input % 10 != 0) Console.Write("and "); break;
                    case 2: Console.Write("twenty "); break;
                    case 3: Console.Write("thirty "); break;
                    case 4: Console.Write("fourty "); break;
                    case 5: Console.Write("fifty "); break;
                    case 6: Console.Write("sixty "); break;
                    case 7: Console.Write("seventy "); break;
                    case 8: Console.Write("eightty "); break;
                    case 9: Console.Write("ninety "); break;
                }
                int clause;
                if(input-(input/100)*100<20)
                     clause=input-(input/100)*100;
                else
                    clause=input%10;
                switch (clause)
                {
                    case 1: Console.Write("one"); break;
                    case 2: Console.Write("two"); break;
                    case 3: Console.Write("three"); break;
                    case 4: Console.Write("four"); break;
                    case 5: Console.Write("five"); break;
                    case 6: Console.Write("six"); break;
                    case 7: Console.Write("seven"); break;
                    case 8: Console.Write("eight"); break;
                    case 9: Console.Write("nine"); break;
                    case 10: Console.WriteLine("ten"); break;
                    case 11: Console.WriteLine("eleven"); break;
                    case 12: Console.WriteLine("twelve"); break;
                    case 13: Console.WriteLine("thirteen"); break;
                    case 14: Console.WriteLine("fourteen"); break;
                    case 15: Console.WriteLine("fifteen"); break;
                    case 16: Console.WriteLine("sixteen"); break;
                    case 17: Console.WriteLine("seventeen"); break;
                    case 18: Console.WriteLine("eighteen"); break;
                    case 19: Console.WriteLine("nineteen"); break;
                }
            }
            Console.WriteLine();
        }
    }

