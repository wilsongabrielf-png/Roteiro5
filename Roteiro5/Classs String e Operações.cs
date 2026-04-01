using System;

class Program
{
    static void Main()
    {
   
        Console.WriteLine("Digite uma frase com espaços no início/fim e palavras separadas por vírgula:");
        string frase = Console.ReadLine();

        string fraseTratada = frase.Trim();
        Console.WriteLine("\nFrase sem espaços extras:");
        Console.WriteLine(fraseTratada);

        string[] partes = fraseTratada.Split(',');

        Console.WriteLine("\nPalavras separadas:");
        foreach (string p in partes)
        {
            Console.WriteLine(p.Trim());
        }

        Console.WriteLine("\nDigite uma palavra que deseja substituir:");
        string antiga = Console.ReadLine();

        Console.WriteLine("Digite a nova palavra:");
        string nova = Console.ReadLine();

        string fraseSubstituida = fraseTratada.Replace(antiga, nova);
        Console.WriteLine("\nFrase após substituição:");
        Console.WriteLine(fraseSubstituida);

        Console.WriteLine("\nDigite uma palavra para verificar se a frase começa com ela:");
        string inicio = Console.ReadLine();

        if (fraseTratada.StartsWith(inicio))
            Console.WriteLine("A frase COMEÇA com essa palavra.");
        else
            Console.WriteLine("A frase NÃO começa com essa palavra.");

        Console.WriteLine("\nDigite uma palavra para verificar se a frase termina com ela:");
        string fim = Console.ReadLine();

        if (fraseTratada.EndsWith(fim))
            Console.WriteLine("A frase TERMINA com essa palavra.");
        else
            Console.WriteLine("A frase NÃO termina com essa palavra.");

        Console.WriteLine("\nDigite um CPF (com ou sem pontos/traços/espaços):");
        string cpf = Console.ReadLine();

        cpf = cpf.Replace(".", "")
                 .Replace("-", "")
                 .Replace(" ", "")
                 .Trim();

        Console.WriteLine("CPF limpo: " + cpf);

        if (cpf.Length != 11)
        {
            Console.WriteLine("CPF inválido! Deve ter 11 dígitos.");
        }
        else
        {
            if (!char.IsDigit(cpf[0]))
            {
                Console.WriteLine("CPF inválido! Deve começar com número.");
            }
            else
            {
                string formatado =
                    cpf.Substring(0, 3) + "." +
                    cpf.Substring(3, 3) + "." +
                    cpf.Substring(6, 3) + "-" +
                    cpf.Substring(9, 2);

                Console.WriteLine("CPF formatado: " + formatado);
            }
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}