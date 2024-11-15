using System;
using Biblioteca_Matriz;

class Ex_11
{
    static int somaDiagonalPrincipal(int[,] mat)
    {

        int linhas = mat.GetLength(0);
        int soma = 0;
        for (int i = 0; i < linhas; i++)
        {
            Console.Write($"{mat[i, i]}|");
            soma += mat[i, i];
        }
        Console.WriteLine();
        return soma;
    }
    static int somaDiagonalSecundaria(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int cols = mat.GetLength(1);
        int j = cols - 1;
        int soma = 0;

        Console.WriteLine("*** ELEMENTOS DA DIAGONAL SECUNDÁRIA ***");
        for (int i = 0; i < linhas; i++, j--)
        {
            Console.WriteLine($"{mat[i, j]}|");
            soma += mat[i, j];

            Console.WriteLine();
        }
        return soma;
    }
    static void Main()
    {
        int cols, linhas;
        Console.WriteLine("Quantidades de linhas e colunas");
        linhas = int.Parse(Console.ReadLine());
        cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[linhas, cols];
        Matriz.gera(matrix);
        Matriz.mostra(matrix);

        int somaPrincipal = somaDiagonalPrincipal(matrix);
        int somaSecundaria = somaDiagonalSecundaria(matrix);

        Console.WriteLine($"Soma da Diagonal Principal:{somaDiagonalPrincipal}");
        Console.WriteLine($"Soma da Diagonal Secundaria:{somaDiagonalSecundaria}");

        if (somaPrincipal > somaSecundaria)
        {
            Console.WriteLine("A diagonal principal é maior que a diagonal secundária.");
        }
        else if (somaPrincipal < somaSecundaria)
        {
            Console.WriteLine("A diagonal secundária é maior que a diagonal principal.");
        }
        else
        {
            Console.WriteLine("As somas das diagonais são iguais.");
        }
    }
}