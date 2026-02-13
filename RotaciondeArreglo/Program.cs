using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original: " + string.Join(", ", arr));

        Console.Write("¿Cuantas posiciones rotar?: ");
        int n = int.Parse(Console.ReadLine()) % arr.Length;

        Console.Write("¿Direccion? (i = izquierda, d = derecha): ");
        string dir = Console.ReadLine().ToLower();

        int[] rotado;
        if (dir == "d")
        {
            // Rotar a la derecha
            rotado = arr.Skip(arr.Length - n).Concat(arr.Take(arr.Length - n)).ToArray();
        }
        else
        {
            // Rotar a la izquierda
            rotado = arr.Skip(n).Concat(arr.Take(n)).ToArray();
        }

        Console.WriteLine("Resultado: " + string.Join(", ", rotado));
    }
}