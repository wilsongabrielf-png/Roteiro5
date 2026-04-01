// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        double numero;

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o{i} número decimal: ");
            numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nResultado:");
            Console.WriteLine($"Número original: {numero}");
            Console.WriteLine($"Arredodamento para baixo: {Math.Round(numero)}");
            Console.WriteLine($"Arredodamento para cima: {Math.Ceiling(numero)}");
            Console.WriteLine($"Trucamento: {Math.Truncate(numero)}");

        }

        Console.WriteLine(" ----------------------------------------- ");


        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}





