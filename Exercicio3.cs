using System;
using Biblioteca_Matriz;

public class Exercicio3
{
    static void Main()
    {
        Console.WriteLine("Digite o número de linhas da matriz:");
        int linhas = int.Parse(Console.ReadLine());// Recebe o valor de linhas fornecido pelo usuario;
        Console.WriteLine("Digite o número de colunas da matriz:");
        int colunas = int.Parse(Console.ReadLine()); // Recebe o valor de colunas fornecido pelo usuario;

        int[,] matriz = new int[linhas, colunas];
        Matriz.Gera(matriz);
        Matriz.Mostra(matriz);

        Console.WriteLine("Digite o número X para contar suas ocorrências:");
        int x = int.Parse(Console.ReadLine());

        int ocorrencias = Matriz.VerificarNum(matriz, x);

        Console.WriteLine($"O número {x} aparece {ocorrencias} vezes na matriz.");

    }
}

