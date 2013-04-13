using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("The equation is not quadratic and has a single root of {0}", -c / b);
        }
        else
        {
            double d=b*b-4*a*c;
            if (d < 0)
            {
                Console.WriteLine("The root are not real");
            }
            else
            {
                if(d==0)
                    Console.WriteLine("There is a double root of {0}",-b/2*a);
                else
                    Console.WriteLine("The roots are {0} and {1}", (-b + Math.Sqrt(d)) / (2 * a), (-b - Math.Sqrt(d)) / (2 * a));
            }
        }

    }
}

