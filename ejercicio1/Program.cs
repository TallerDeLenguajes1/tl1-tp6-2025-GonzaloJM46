using System;

class EntradaNumerica
{
    static void Main()
    {
        int num = 0, ultimo;

        do
        {
            Console.WriteLine("Escriba un número mayor que 0:");
        } while (!int.TryParse(Console.ReadLine(), out num) || num < 1);

        Console.WriteLine($"Ingresaste el número: {num}");

        if (num < 10) {
            Console.Write(num);
        } else {
            while (num != 0)
            {
                ultimo = num % 10;
                num = num / 10;
                Console.Write(ultimo);
            }
        }
    }
}
