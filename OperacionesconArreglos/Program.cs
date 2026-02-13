using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> lista = new List<int> { 10, 20, 30, 40, 50 };
        Console.WriteLine("Lista inicial: " + string.Join(", ", lista));

 
        Console.Write("\nNumero a insertar: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("En que posicion: ");
        int p = int.Parse(Console.ReadLine());
        lista.Insert(p, n);

        Console.Write("\nPosicion para eliminar: ");
        int e = int.Parse(Console.ReadLine());
        lista.RemoveAt(e);


        Console.Write("\nNumero a buscar: ");
        int b = int.Parse(Console.ReadLine());
        int ind = lista.IndexOf(b);

        Console.WriteLine("\n--- RESULTADOS ---");
        Console.WriteLine("Lista final: " + string.Join(", ", lista));
        Console.WriteLine("El numero buscado esta en el indice: " + ind);
    }
}