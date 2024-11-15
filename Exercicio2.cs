using System;
using Biblioteca_Matriz;

public class Exercicio2
{
    static void Main()
    {
        Console.WriteLine("Digite o número de linhas da matriz:");
        int linhas = int.Parse(Console.ReadLine())
        Console.WriteLine("Digite o número de colunas da matriz:");
        int colunas = int.Parse(Console.ReadLine()); 

        int[,] matriz = new int[linhas, colunas];
        Matriz.Gera(matriz);
        Matriz.Mostra(matriz);

        int menorValor = Matriz.EncontrarMenorValor(matriz);
        Console.WriteLine($"O menor valor da matriz é {menorValor}");

    }
}

