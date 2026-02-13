using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> lista = new List<int> { 10, 20, 30, 40 };
        int suma = lista.Sum();
        Console.WriteLine("La suma es: " + suma);
    }
}