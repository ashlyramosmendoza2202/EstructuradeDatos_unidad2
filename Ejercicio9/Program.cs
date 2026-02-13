using System;
class Program
{
    static void Main()
    {
        string s = "";
        while (s != "s")
        {
            Console.Write("N1: "); double a = double.Parse(Console.ReadLine());
            Console.Write("N2: "); double b = double.Parse(Console.ReadLine());
            Console.Write("Op: "); string o = Console.ReadLine();
            if (o == "+") Console.WriteLine(a + b);
            if (o == "-") Console.WriteLine(a - b);
            if (o == "*") Console.WriteLine(a * b);
            if (o == "/") Console.WriteLine(a / b);
            Console.Write("¿Salir? (s/n): "); s = Console.ReadLine();
        }
    }
}