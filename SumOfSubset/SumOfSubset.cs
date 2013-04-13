using System;

    class SumOfSubset
    {
        static void Main(string[] args)
        {
            bool flag = false;
            double[] set = new double[5];
            for (int i = 0; i < 5; i++)
            {
                set[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                        continue;
                    if (set[i] + set[j] == 0 )
                    { flag = true; break; }
                    for (int k = 0; k < 5; k++)
                    {
                        if (j == k)
                            continue;
                        if (set[i] + set[j]+set[k] == 0 )
                        { flag = true; break; }
                        for (int l = 0; l < 5; l++)
                        {
                            if (l == k)
                                continue;
                            if (set[i] + set[j] + set[k] +set[l]== 0 )
                            { flag = true; break; }

                        }
                    }
                }
            }
            if(set[0] + set[1] + set[2] +set[3]+set[4]== 0)
                flag = true;
            Console.WriteLine("It is {0} that the sum of some subset is 0",flag);
        }
        
    }

