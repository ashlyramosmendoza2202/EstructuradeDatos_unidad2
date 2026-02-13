using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> lista = new List<int> { 10, 20, 30, 40 };
        double promedio = lista.Average();
        Console.WriteLine("El promedio es: " + promedio);
    }
}