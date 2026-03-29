using System;
class Program
{
    static void Main()
    {
        string[] nomes = new string[10];
        double[] precos = new double[10];

        Console.WriteLine("Cadastro de 10 produtos:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Nome do produto {i + 1}: ");
            nomes[i] = Console.ReadLine();

            Console.Write($"Preço do produto {i + 1}: ");
            precos[i] = double.Parse(Console.ReadLine());
        }

        Console.Write("\nDigite um valor para pesquisa: ");
        double limite = double.Parse(Console.ReadLine());

        Console.WriteLine($"\nProdutos com preço até {limite}:");
        for (int i = 0; i < 10; i++)
        {
            if (precos[i] <= limite)
            {
                Console.WriteLine($"Produto: {nomes[i]} | Preço: {precos[i]}");
            }
        }
    }
}
