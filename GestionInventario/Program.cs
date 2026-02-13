using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
    
        List<string> inv = new List<string> { "Laptop", "Mouse", "Teclado" };

        inv.Add("Monitor"); 
        inv.Remove("Mouse"); 

        Console.Write("Buscar producto: ");
        string p = Console.ReadLine();
        Console.WriteLine(inv.Contains(p) ? "Disponible" : "No existe");
        Console.WriteLine("Inventario: " + string.Join(", ", inv));
    }
}
