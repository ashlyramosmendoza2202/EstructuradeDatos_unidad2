using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Palabra: ");
        string p = Console.ReadLine().ToLower();
        string r = new string(p.Reverse().ToArray());

        if (p == r) Console.WriteLine("Es palindroma");
        else Console.WriteLine("No es palindroma");
    }
}