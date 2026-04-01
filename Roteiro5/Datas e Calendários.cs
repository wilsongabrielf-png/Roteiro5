using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a data do compromisso (dd/MM/yyyy HH:mm): ");
        DateTime compromisso = DateTime.ParseExact(
            Console.ReadLine(),
            "dd/MM/yyyy HH:mm",
            null
        );

        DateTime agora = DateTime.Now;

        int dias = (int)Math.Ceiling((compromisso - agora).TotalDays);

        string diaSemana = compromisso.ToString("dddd");

        string mensagem = string.Format(
            "Olá, {0}!\nSeu compromisso será em {1} dias, na {2}.\nData marcada: {3:dd/MM/yyyy} às {3:HH:mm}",
            nome,
            dias,
            diaSemana,
            compromisso
        );

        Console.WriteLine("\n" + mensagem);


        Console.WriteLine("\n=== Cadastro de Evento ===");

        Console.Write("Nome do evento: ");
        string evento = Console.ReadLine();

        Console.Write("Data do evento (dd/MM/yyyy): ");
        DateTime dataEvento = DateTime.ParseExact(
            Console.ReadLine(),
            "dd/MM/yyyy",
            null
        );

        Console.Write("Valor do ingresso: ");
        double valor = Convert.ToDouble(Console.ReadLine());

        Console.Write("Categoria (VIP/Comum): ");
        string categoria = Console.ReadLine().ToUpper();

        bool vip = categoria.Contains("VIP");

        int diasEvento = (int)Math.Ceiling((dataEvento - DateTime.Now).TotalDays);

        double desconto = vip ? 0.20 : 0.0;
        double valorFinal = Math.Round(valor * (1 - desconto), 2);

        string ingresso = string.Format(
            "\n=========== INGRESSO ===========\n" +
            "Evento: {0,-20}\n" +
            "Data: {1:dd/MM/yyyy}\n" +
            "Dias restantes: {2}\n" +
            "Categoria: {3}\n" +
            "Valor: {4,10:C}\n" +
            "Desconto: {5,10:P}\n" +
            "Total: {6,10:C}\n" +
            "================================",
            evento,
            dataEvento,
            diasEvento,
            vip ? "VIP" : "Comum",
            valor,
            desconto,
            valorFinal
        );

        Console.WriteLine(ingresso);

        Console.WriteLine("\nAgora formatado: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
        Console.WriteLine("Hoje: " + DateTime.Today);
        Console.WriteLine("UTC: " + DateTime.UtcNow);

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}