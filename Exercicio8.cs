using System;
using System.Linq.Expressions;
using Biblioteca_Matriz;

class Ex_8
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n >= 2 && n <= 500000)
        {
            int[,] matriz = new int[n, 2];

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                if (0 <= x && x <= 500 && 0 <= y && y <= 500)
                {
                    matriz[i, 0] = x;
                    matriz[i, 1] = y;
                }
            }

            bool encontrado = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (matriz[i, 0] == matriz[j, 0] && matriz[i, 1] == matriz[j, 1])
                    {
                        encontrado = true;
                        break;
                    }
                }
                if (encontrado)
                    break;
            }

            if (encontrado)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}


