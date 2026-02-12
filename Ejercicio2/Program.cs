using System;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número para verificar si es perfecto: ");
            int numero = int.Parse(Console.ReadLine());

            int suma = 0;
            int i = 1;

            while (i < numero)
            {
                if (numero % i == 0)
                {
                    suma += i;
                }
                i++;
            }

            if (suma == numero)
            {
                Console.WriteLine("\nEl número " + numero + " es un NÚMERO PERFECTO.");
            }
            else
            {
                Console.WriteLine("\nEl número " + numero + " NO es un número perfecto.");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}