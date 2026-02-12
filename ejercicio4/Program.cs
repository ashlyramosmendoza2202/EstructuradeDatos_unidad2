using System;
class Program
{
    static void Main()
    {
        Console.Write("Primer número: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Segundo número: ");
        int b = int.Parse(Console.ReadLine());
        int max = (a > b) ? a : b;
        int mcm = max;
        while (mcm % a != 0 || mcm % b != 0)
        {
            mcm += max;
        }
        Console.WriteLine("El MCM es: " + mcm);
        Console.ReadKey();
    }
}