using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<int> lista = new LinkedList<int>();

        Console.Write("Numero para agregar: ");
        lista.AddLast(int.Parse(Console.ReadLine()));

        Console.Write("Numero para eliminar: ");
        lista.Remove(int.Parse(Console.ReadLine()));

        Console.Write("Numero para buscar: ");
        bool existe = lista.Contains(int.Parse(Console.ReadLine()));

        Console.WriteLine("Lista: " + string.Join(" -> ", lista));
        Console.WriteLine("¿Existe?: " + existe);
    }
}