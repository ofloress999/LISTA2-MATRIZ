using System;
using Biblioteca_Matriz;

public class Exercicio4
{
    static void Main()
    {
        Console.WriteLine("Digite o número de linhas da matriz:");
        int linhas = int.Parse(Console.ReadLine());// Recebe o valor de linhas fornecido pelo usuario;
        Console.WriteLine("Digite o número de colunas da matriz:");
        int colunas = int.Parse(Console.ReadLine()); // Recebe o valor de colunas fornecido pelo usuario;

        if(linhas < 100 && colunas < 100)
        {
            int[,] matriz = new int[linhas, colunas];
            Matriz.Gera(matriz);
            Matriz.Mostra(matriz);
            Matriz.ExibeDiagonal(matriz);
        } else
        {
            Console.WriteLine("ERRO!! Sua matriz tem mais de 100 linhas ou 100 colunas!");
        }
    }
}