using System;
using Biblioteca_Matriz;

public class Exercicio1
{
    static void Main()
    {
        Console.WriteLine("Digite o número de linhas da matriz:");
        int linhas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número de colunas da matriz:");
        int colunas = int.Parse(Console.ReadLine());

        /* Declara uma matriz bidimensional de inteiros chamada 'matriz' 
           e a inicializa com o tamanho especificado de linhas e colunas */
        int[,] matriz = new int[linhas, colunas]; 
        Matriz.Gera(matriz); // Puxa a função (GERA) da biblioteca matriz;
        Matriz.Mostra(matriz); // Puxa a função (Mostra) da biblioteca matriz;

        int maiorValor = Matriz.EncontrarMaiorValor(matriz);
        Console.WriteLine($"\nO maior valor da matriz é: {maiorValor}");
    }
}

