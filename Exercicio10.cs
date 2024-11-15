using System;

class Programa
{
    static void Main()
    {
        // Leitura do número de regiões (R) e de cidades por região (C)
        Console.Write("Digite o número de regiões (R): ");
        int R = int.Parse(Console.ReadLine());
        Console.Write("Digite o número de cidades por região (C): ");
        int C = int.Parse(Console.ReadLine());

        // Criando a matriz de tropas com R regiões e C cidades
        int[,] tropas = new int[R, C];

        // Preenchendo a matriz com números aleatórios entre 0 e 100
        Random random = new Random();
        for (int i = 0; i < R; i++)
        {
            for (int j = 0; j < C; j++)
            {
                tropas[i, j] = random.Next(0, 101); // Número aleatório entre 0 e 100
            }
        }

        // Exibindo a matriz das tropas (quantidade de tropas por cidade)
        Console.WriteLine("\nMatriz das Tropas (Quantidade de Tropas por Cidade):");
        for (int i = 0; i < R; i++)
        {
            Console.Write("Região " + (i + 1) + ": ");
            for (int j = 0; j < C; j++)
            {
                Console.Write(tropas[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Calculando e exibindo a força total de cada região
        Console.WriteLine("\nForça Total das Regiões:");
        for (int i = 0; i < R; i++)
        {
            int soma = 0;
            for (int j = 0; j < C; j++)
            {
                soma += tropas[i, j]; // Somando as tropas da região (linha)
            }
            Console.WriteLine("Região " + (i + 1) + ": " + soma + " tropas");
        }
    }
}