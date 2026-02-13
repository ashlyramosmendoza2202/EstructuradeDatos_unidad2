using System;

class Program
{
    static void Main()
    {
        int pos = 0;
        int neg = 0;
        int cero = 0;

        for (int i = 1; i <= 10; i++)
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 0) pos++;
            if (n < 0) neg++;
            if (n == 0) cero++;
        }

        Console.WriteLine(pos);
        Console.WriteLine(neg);
        Console.WriteLine(cero);
    }
}