using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> lista = new List<int> { 15, 8, 25, 3, 10 };

        Console.WriteLine("Máximo: " + lista.Max());
        Console.WriteLine("Mínimo: " + lista.Min());
    }
}
