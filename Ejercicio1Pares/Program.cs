using System;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número para contar los pares hasta ese límite: ");
            int limite = int.Parse(Console.ReadLine());

            int contadorPares = 0;


            for (int i = 1; i <= limite; i++)
            {

                if (i % 2 == 0)
                {
                    contadorPares++;
                }
            }


            Console.WriteLine("\nEntre 1 y " + limite + " hay " + contadorPares + " números pares.");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}