using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        LinkedList<int> lista = new LinkedList<int>(new[] { 1, 2, 3, 4 });
        Console.WriteLine("Antes: " + string.Join(" -> ", lista));

        var invertida = new LinkedList<int>(lista.Reverse());
        Console.WriteLine("Despues: " + string.Join(" -> ", invertida));
    }
}