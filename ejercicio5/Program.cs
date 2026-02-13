using System;
class Program
{
    static void Main()
    {
        int mayor = int.MinValue;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Ingrese número " + i + ": ");
            int num = int.Parse(Console.ReadLine());
            if (num > mayor) mayor = num;
        }
        Console.WriteLine("El número mayor es: " + mayor);
        Console.ReadKey();
    }
}