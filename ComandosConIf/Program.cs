using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número entre 1 y 12:");
        int mes = int.Parse(Console.ReadLine());

        if (mes == 1 || mes == 2 || mes == 3)
        {
            Console.WriteLine("Verano");
        }
        else if (mes == 4 || mes == 5 || mes == 6)
        {
            Console.WriteLine("Otoño");
        }
        else if (mes == 7 || mes == 8 || mes == 9)
        {
            Console.WriteLine("Primavera");
        }
        else
        {
            Console.WriteLine("Invierno");
        }
    }
}