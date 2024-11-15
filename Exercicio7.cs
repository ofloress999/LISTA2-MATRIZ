using System;
using System.Linq.Expressions;
using Biblioteca_Matriz;

public class Exercicio7
{
   static void Main()
   {
           //Obtendo primeira matriz
           Console.WriteLine("Matriz 1 - Linhas x Colunas");
           double[,] matrizOne = Matriz.CriarMatrizReal();
           Matriz.GeraDouble(matrizOne);

           //Obtendo segunda matriz
           Console.WriteLine("\nMatriz 2 - Linhas x Colunas");
           double[,] matrizTwo = Matriz.CriarMatrizReal();
           Matriz.GeraDouble(matrizTwo);
        
           Console.WriteLine("\nEscolha as opções a seguir:");
           Console.WriteLine("1 - Somar as duas matrizes");
           Console.WriteLine("2 - Subtrair a primeira matriz da segunda");
           Console.WriteLine("3 - Adicionar uma constante as duas matrizes");
           Console.WriteLine("4 - Imprimir as matrizes.");
           int escolha = int.Parse(Console.ReadLine());

           switch (escolha)
        {
            case 1:
                Console.WriteLine("\n1º Matriz");
                Matriz.MostraReal(matrizOne);
                Console.WriteLine("\n2º Matriz");
                Matriz.MostraReal(matrizTwo);
                Console.WriteLine("\nSomando as duas matrizes...");
                double[,]somaMatrizes = Matriz.VerificarOrdemDouble(matrizOne, matrizTwo);
                Matriz.MostraReal(somaMatrizes);
                break;
                
            case 2:
                Console.WriteLine("\n1º Matriz");
                Matriz.MostraReal(matrizOne);
                Console.WriteLine("\n2º Matriz");
                Matriz.MostraReal(matrizTwo);
                Console.WriteLine("\nSubtraindo a primeira matriz da segunda...");
                double[,] subtrairMatrizes = Matriz.SubtrairMatrizes(matrizOne, matrizTwo);
                Matriz.MostraReal(subtrairMatrizes);
                break;

            case 3:
                Console.WriteLine("Digite a constante a ser adicionada: ");
                double constante = double.Parse(Console.ReadLine());

                // Exibindo matrizes antes da adição da constante
                Console.WriteLine("\nMatrizes antes de adicionar a constante:");
                Console.WriteLine("\n1º Matriz:");
                Matriz.MostraReal(matrizOne);
                Console.WriteLine("\n2º Matriz:");
                Matriz.MostraReal(matrizTwo);

                // Adiciona a constante às matrizes
                Matriz.AdicionarConstante(matrizOne, constante);
                Matriz.AdicionarConstante(matrizTwo, constante);

                // Exibindo matrizes após a adição da constante
                Console.WriteLine("\nMatrizes após adicionar a constante:");
                Console.WriteLine("\n1º Matriz com constante adicionada:");
                Matriz.MostraReal(matrizOne);
                Console.WriteLine("\n2º Matriz com constante adicionada:");
                Matriz.MostraReal(matrizTwo);
                break;


            case 4:
                Console.WriteLine("\nImprimindo as matrizes...");
                Console.WriteLine("\n1º Matriz");
                Matriz.MostraReal(matrizOne);
                Console.WriteLine("\n2º Matriz");
                Matriz.MostraReal(matrizTwo);
                break;

            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
}


