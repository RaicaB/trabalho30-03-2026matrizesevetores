using System;

class Program
{
    static void Main()
    {
        int linhas = 3;
        int colunas = 5;
        int[,] matriz = new int[linhas, colunas];

        Console.WriteLine("Digite os 15 números para preencher a matriz 3x5:");
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("\nSoma dos valores de cada linha:");
        for (int i = 0; i < linhas; i++)
        {
            int soma = 0;
            for (int j = 0; j < colunas; j++)
            {
                soma += matriz[i, j];
            }
            Console.WriteLine($"Linha {i}: {soma}");
        }
    }
}