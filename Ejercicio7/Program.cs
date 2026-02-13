using System;
class Program
{
    static void Main()
    {
        Console.Write("Inicio: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Fin: "); int b = int.Parse(Console.ReadLine());
        for (int i = a; i <= b; i++) if (i % 5 == 0) Console.Write(i + " ");
        Console.ReadKey();
    }
}
