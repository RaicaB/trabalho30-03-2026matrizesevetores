using System;
class Program
{
    static void Main()
    {
        string[] nomes = new string[10];
        double[,] notas = new double[10, 3];
        double[] medias = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"\nDigite o nome do aluno {i + 1}: ");
            nomes[i] = Console.ReadLine();

            double soma = 0;
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite a nota {j + 1} de {nomes[i]}: ");
                notas[i, j] = double.Parse(Console.ReadLine());
                soma += notas[i, j];
            }
            medias[i] = soma / 3.0;
        }
        Console.WriteLine("\n===== RELATÓRIO FINAL =====");
        for (int i = 0; i < 10; i++)
        {
            if (medias[i] >= 7.0)
                Console.ForegroundColor = ConsoleColor.Blue; 
            else
                Console.ForegroundColor = ConsoleColor.Red;  

            Console.WriteLine($"\nAluno: {nomes[i]}");
            Console.Write("Notas: ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{notas[i, j]} ");
            }
            Console.WriteLine($"\nMédia: {medias[i]:F2}");
            Console.WriteLine(medias[i] >= 7.0 ? "Situação: Aprovado" : "Situação: Reprovado");

            Console.ResetColor();
        }
    }
}

