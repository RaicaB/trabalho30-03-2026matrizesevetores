using System;
class Program
{
    static void Main()
    {
        int[,] matriz = new int[5, 5];
        int valor = 1;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matriz[i, j] = valor;
                valor++;
            }
        }

        Console.WriteLine("Matriz 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matriz[i, j].ToString("D2") + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nValores da diagonal principal:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(matriz[i, i]);
        }

        Console.WriteLine("\nValores da diagonal secundária:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(matriz[i, 4 - i]);
        }
    }
}
