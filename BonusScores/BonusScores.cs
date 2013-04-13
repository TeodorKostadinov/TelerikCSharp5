using System;

class BonusScores
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine();
        int score;
        if (int.TryParse(line,out score) == true)
        {
            switch (score)
            {
                case 1:
                case 2:
                case 3: score = score * 10; Console.WriteLine(score); break;
                case 4:
                case 5:
                case 6: score = score * 100; Console.WriteLine(score); break;
                case 7:
                case 8:
                case 9: score = score * 1000; Console.WriteLine(score); break;
                default: Console.WriteLine("The value is a zero or not a digit"); break;
            }
        }
        else
            Console.WriteLine("The value is not a number");
    }
}

