using System;
class Program
{
    static void Main()
    {
        char[,] tabuleiro = new char[3, 3];
        int jogada = 0;
        bool fimDeJogo = false;

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                tabuleiro[i, j] = ' ';

        while (!fimDeJogo && jogada < 9)
        {
            Console.Clear();
            ExibirTabuleiro(tabuleiro);

            char simbolo = (jogada % 2 == 0) ? 'X' : 'O';
            Console.WriteLine($"\nJogador {(simbolo == 'X' ? 1 : 2)} ({simbolo}), faça sua jogada:");

            Console.Write("Linha (0-2): ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Coluna (0-2): ");
            int coluna = int.Parse(Console.ReadLine());

            if (linha >= 0 && linha < 3 && coluna >= 0 && coluna < 3 && tabuleiro[linha, coluna] == ' ')
            {
                tabuleiro[linha, coluna] = simbolo;
                jogada++;

                if (VerificarVitoria(tabuleiro, simbolo))
                {
                    Console.Clear();
                    ExibirTabuleiro(tabuleiro);
                    Console.WriteLine($"\nJogador {(simbolo == 'X' ? 1 : 2)} venceu!");
                    fimDeJogo = true;
                }
            }
            else
            {
                Console.WriteLine("Posição inválida ou já ocupada! Pressione ENTER para tentar novamente.");
                Console.ReadLine();
            }
        }

        if (!fimDeJogo)
        {
            Console.Clear();
            ExibirTabuleiro(tabuleiro);
            Console.WriteLine("\nEmpate!");
        }
    }

    static void ExibirTabuleiro(char[,] tabuleiro)
    {
        Console.WriteLine("  0   1   2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tabuleiro[i, j]);
                if (j < 2) Console.Write(" | ");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine(" ---+---+---");
        }
    }

    static bool VerificarVitoria(char[,] tabuleiro, char simbolo)
    {
        for (int i = 0; i < 3; i++)
            if (tabuleiro[i, 0] == simbolo && tabuleiro[i, 1] == simbolo && tabuleiro[i, 2] == simbolo)
                return true;

        for (int j = 0; j < 3; j++)
            if (tabuleiro[0, j] == simbolo && tabuleiro[1, j] == simbolo && tabuleiro[2, j] == simbolo)
                return true;

        if (tabuleiro[0, 0] == simbolo && tabuleiro[1, 1] == simbolo && tabuleiro[2, 2] == simbolo)
            return true;

        if (tabuleiro[0, 2] == simbolo && tabuleiro[1, 1] == simbolo && tabuleiro[2, 0] == simbolo)
            return true;

        return false;
    }
}
