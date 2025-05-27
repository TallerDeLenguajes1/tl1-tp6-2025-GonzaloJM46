using System;

class EntradaNumerica
{
    static void Main()
    {
        int num = 0;

        do
        {
            Console.WriteLine("Escriba un número mayor que 0:");
        } while (!int.TryParse(Console.ReadLine(), out num) || num < 1);

        Console.WriteLine($"Ingresaste el número: {num}");
    }
}
