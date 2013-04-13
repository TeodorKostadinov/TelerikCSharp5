using System;

class FindSignOfProduct
{
    static void Main(string[] args)
    {
        double firstReal = double.Parse(Console.ReadLine());
        double secondReal = double.Parse(Console.ReadLine());
        double thirdReal = double.Parse(Console.ReadLine());

        if (firstReal >= 0)
        {
            if (secondReal >= 0)
            {
                if (thirdReal >= 0)
                    Console.WriteLine("The sign is plus");
                else
                    Console.WriteLine("The sign is minus");
            }
            else
            {
                if (thirdReal >= 0)
                    Console.WriteLine("The sign is minus");
                else
                    Console.WriteLine("The sign is plus");
            }
        }
        else
        {
            if (secondReal >= 0)
            {
                if (thirdReal >= 0)
                    Console.WriteLine("The sign is minus");
                else
                    Console.WriteLine("The sign is plus");
            }
            else
            {
                if(thirdReal>=0)
                    Console.WriteLine("The sign is plus");
                else
                    Console.WriteLine("The sign is minus");
            }
        }
    }
}

