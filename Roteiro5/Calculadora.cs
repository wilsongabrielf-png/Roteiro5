using System;

class Program
{
    static void Main()
    {

        double capital, taxa, montante, lucro, meta;

        int meses;

        Console.Write("Digite o capital inicial: ");
        capital = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a taxa de juros mensal (em %): ");
        taxa = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o número de meses:");
        meses = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a meta de lucro: ");
        meta = Convert.ToDouble(Console.ReadLine());

        taxa = taxa / 100;

        montante = capital * Math.Pow(1 + taxa, meses);

        lucro = montante - capital;

        double lucroArredondado = Math.Round(lucro, 2);

        Console.WriteLine($"\nResultados:");
        Console.WriteLine($"Montante final:{montante: F2}");
        Console.WriteLine($"Lucro: {lucroArredondado}");

        if (lucroArredondado >= meta)
        {
            Console.WriteLine("Meta atingida.");
        }
        else
        {
            Console.WriteLine("Meta não atingida.");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}


