using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> lista = new List<int> { 1, 2, 3, 4, 5 };

        lista.Reverse();

        foreach (int x in lista) Console.Write(x + " ");
    }
}