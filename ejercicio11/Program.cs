using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Oracion: ");
        string entrada = Console.ReadLine().ToLower();
        string p = new string(entrada.Where(c => !char.IsWhiteSpace(c)).ToArray());
        string r = new string(p.Reverse().ToArray());

        if (p == r) Console.WriteLine("Es palindroma");
        else Console.WriteLine("No es palindroma");
    }
}