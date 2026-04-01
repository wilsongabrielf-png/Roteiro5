using System;

class Program
{
    static void Main()
    {
        string[] nomes = { "Teclado", "Mouse", "Monitor" };
        double[] precos = { 150.50, 80.99, 1200.00 };
        int[] quantidades = { 2, 3, 1 };

        double subtotal = 0;

        Console.WriteLine("===============================================");
        Console.WriteLine("{0,-15} {1,10} {2,10} {3,12}", "Produto", "Preço", "Qtd", "Total");
        Console.WriteLine("===============================================");

        for (int i = 0; i < nomes.Length; i++)
        {
            double totalItem = precos[i] * quantidades[i];
            subtotal += totalItem;

            Console.WriteLine("{0,-15} {1,10:C} {2,10:N0} {3,12:C}",
                nomes[i],
                precos[i],
                quantidades[i],
                totalItem);
        }

        Console.WriteLine("===============================================");

        double desconto = subtotal * 0.10;
        double totalFinal = subtotal - desconto;

        Console.WriteLine($"Subtotal: {subtotal:C}");
        Console.WriteLine($"Desconto (10%): {desconto:P}");
        Console.WriteLine($"Valor do desconto: {desconto:C}");
        Console.WriteLine($"Total final: {totalFinal:C}");

        Console.WriteLine("===============================================");
    }
}