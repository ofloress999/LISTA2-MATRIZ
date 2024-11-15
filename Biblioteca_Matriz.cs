using System;

namespace Biblioteca_Matriz
{
    class Matriz
    {
        // Método para criar uma matriz com tamanho definido pelo usuário
        public static int[,] CriarMatriz()
        {
            Console.Write("Digite o número de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine());

            return new int[linhas, colunas];
        }
        //----------------------------------------------------------------------

        // Método para criar uma matriz com tamanho definido pelo usuário (para valores reais)
        public static double[,] CriarMatrizReal()
        {
            Console.Write("Digite o número de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine());

            return new double[linhas, colunas];
        }

        //----------------------------------------------------------------------

        // Função para ler valores da matriz inseridos pelo usuário
        public static void Leia(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        //----------------------------------------------------------------------

        // Função para gerar valores aleatórios para a matriz
        public static void Gera(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);
            Random random = new Random();

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    mat[i, j] = random.Next(0, 100);
                }
            }
        }
        //----------------------------------------------------------------------

        // Função para gerar valores aleatórios para a matriz de valores reais (double)
        public static void GeraDouble(double[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);
            Random random = new Random();

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    mat[i, j] = random.NextDouble() * 100;
                }
            }
        }
        //----------------------------------------------------------------------

        // Função para exibir os valores da matriz 
        public static void Mostra(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"{mat[i, j],3} |");
                }
                Console.WriteLine();
            }
        }
        //----------------------------------------------------------------------

        // Função para exibir os valoresreais da matriz 
        public static void MostraReal(double[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"{mat[i, j],6:F2} |"); // Exibe o valor formatado com 2 casas decimais
                }
                Console.WriteLine();
            }
        }
        //----------------------------------------------------------------------

        // Método para encontrar o maior valor na matriz
        public static int EncontrarMaiorValor(int[,] mat)
        {
            int maior = mat[0, 0];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] > maior)
                    {
                        maior = mat[i, j];
                    }
                }
            }
            return maior;
        }
        //----------------------------------------------------------------------

        // Método para encontrar o menor valor da matriz
        public static int EncontrarMenorValor(int[,] mat)
        {
            int menor = mat[0, 0];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] < menor)
                    {
                        menor = mat[i, j];
                    }
                }
            }
            return menor;
        }
        //----------------------------------------------------------------------

        // Método para verificar quantas vezes o número X existe na matriz
        public static int VerificarNum(int[,] mat, int x)
        {
            int contador = 0;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == x)
                    {
                        contador++;
                    }
                }
            }
            return contador;
        }
        //----------------------------------------------------------------------

        // Método para exibir a diagonal principal da matriz
        public static void ExibeDiagonal(int[,] mat)
        {
            Console.WriteLine("Diagonal Principal:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.WriteLine($"{mat[i, i],3} ");
            }
        }
        //----------------------------------------------------------------------

        // Método para exibir a diagonal secundária da matriz
        public static void ExibeDiagonalSecundaria(int[,] mat)
        {
            Console.WriteLine("Diagonal Secundária:");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.Write($"{mat[i, mat.GetLength(0) - 1 - i],3} ");
            }
            Console.WriteLine();
        }
        //----------------------------------------------------------------------

        // Método para verificar se duas matrizes têm a mesma ordem e somá-las
        public static int[,] VerificarOrdem(int[,] matA, int[,] matB)
        {
            int linhasA = matA.GetLength(0);
            int colunasA = matA.GetLength(1);
            int linhasB = matB.GetLength(0);
            int colunasB = matB.GetLength(1);

            if (linhasA != linhasB || colunasA != colunasB)
            {
                Console.WriteLine("\nAs matrizes devem ter a mesma ordem para serem somadas.");
                return null;
            }

            int[,] somaMatrizes = new int[linhasA, colunasA];

            for (int i = 0; i < linhasA; i++)
            {
                for (int j = 0; j < colunasA; j++)
                {
                    somaMatrizes[i, j] = matA[i, j] + matB[i, j];
                }
            }
            return somaMatrizes;
        }

        //----------------------------------------------------------------------

        // Método para verificar se duas matrizes têm a mesma ordem e somá-las
        public static double[,] VerificarOrdemDouble(double[,] matA, double[,] matB)
        {
            int linhasA = matA.GetLength(0);
            int colunasA = matA.GetLength(1);
            int linhasB = matB.GetLength(0);
            int colunasB = matB.GetLength(1);

            if (linhasA != linhasB || colunasA != colunasB)
            {
                Console.WriteLine("\nAs matrizes devem ter a mesma ordem para serem somadas.");
                return null;
            }

            double[,] somaMatrizes = new double[linhasA, colunasA];

            for (int i = 0; i < linhasA; i++)
            {
                for (int j = 0; j < colunasA; j++)
                {
                    somaMatrizes[i, j] = matA[i, j] + matB[i, j];
                }
            }
            return somaMatrizes;
        }
        //----------------------------------------------------------------------

        // Método para subtrair as duas matrizes
        public static double[,] SubtrairMatrizes(double[,] matA, double[,] matB)
        {
            int linhasA = matA.GetLength(0);
            int colunasA = matA.GetLength(1);
            int linhasB = matB.GetLength(0);
            int colunasB = matB.GetLength(1);

            if(linhasA != linhasB || colunasA != colunasB)
            {
                Console.WriteLine("\nAs matrizes devem ter a mesma ordem para serem subtraidas.");
                return null;
            }

            double[,] subtrairMatrizes = new double[linhasA, colunasA];

            for (int i = 0; i < linhasA; i++)
            {
                for (int j = 0; j < colunasA; j++)
                {
                    subtrairMatrizes[i,j] = matA[i, j] - matB[i, j];
                }
            }
            return subtrairMatrizes;

        }
        //----------------------------------------------------------------------

        // Método para adicionar uma constante a cada elemento de uma matriz
        public static void AdicionarConstante(double[,] matriz, double constante)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matriz[i, j] += constante;
                }
            }
        }

    }
}
