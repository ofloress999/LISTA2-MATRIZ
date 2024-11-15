using System;
using Biblioteca_Matriz;

public class Exercicio6
{
    static void Main()
    {
        Console.Write("Digite o número de linhas x colunas da 1º matriz: ");
        int linhas = int.Parse(Console.ReadLine());
        int colunas = int.Parse(Console.ReadLine());

        int[,] matrizOne = new int[linhas, colunas];
        Matriz.Gera(matrizOne);

        Console.Write("Digite o número de linhas x colunas da 2º matriz:");
        linhas = int.Parse(Console.ReadLine());
        colunas = int.Parse(Console.ReadLine());

        int[,] matrizTwo = new int[linhas, colunas];
        Matriz.Gera(matrizTwo);

        Console.WriteLine("\n Matriz 1");
        Matriz.Mostra(matrizOne);
        Console.WriteLine("\n Matriz 2");
        Matriz.Mostra(matrizTwo);

        int[,] matrizSoma =  Matriz.VerificarOrdem(matrizOne, matrizTwo);
        
        if(matrizSoma != null)
        {
            Console.WriteLine("\n Matriz resultante da soma:");
            Matriz.Mostra(matrizSoma);
        }

    }
}