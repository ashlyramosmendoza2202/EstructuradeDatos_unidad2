using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> lista = new List<string> { "Manzana", "Pera", "Uva" };

        Console.Write("Elemento a buscar: ");
        string buscar = Console.ReadLine();

        int posicion = lista.IndexOf(buscar);

        if (posicion != -1) Console.WriteLine("Posicion: " + posicion);
        else Console.WriteLine("No se encontro");
    }
}