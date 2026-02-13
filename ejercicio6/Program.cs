using System;
class Program
{
    static void Main()
    {
        Console.Write("Cant: ");
        int c = int.Parse(Console.ReadLine()), p = 0;
        for (int i = 0; i < c; i++)
        {
            Console.Write("Num: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 2) continue;
            bool esP = true;
            for (int j = 2; j < n; j++) if (n % j == 0) esP = false;
            if (esP) p++;
        }
        Console.WriteLine("Primos: " + p);
        Console.ReadKey();
    }
}