using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> circular = new List<int> { 10, 20, 30 };
        // Simulación de recorrido circular (3 vueltas)
        for (int i = 0; i < 9; i++)
        {
            Console.Write(circular[i % circular.Count] + " ");
        }
    }
}