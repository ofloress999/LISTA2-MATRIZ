using System;
using Biblioteca_Matriz;

public class Exercicio9
{
    static void Main()
    {
        Console.WriteLine("Digite o número de redes lançadas: ");
        int n = int.Parse(Console.ReadLine());

        // Determinar os limites do "mar" (matriz)
        Console.WriteLine("Digite os limites do mar (dimensão máxima dos valores X e Y): ");
        Console.Write("Digite o limite X: ");
        int limiteX = int.Parse(Console.ReadLine());
        Console.Write("Digite o limite Y: ");
        int limiteY = int.Parse(Console.ReadLine());

        // Criar uma matriz para representar o mar
        int[,] mar = new int[limiteX + 1, limiteY + 1];

        // Processar as redes
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nDigite os limites da rede {i + 1} (Xi, Xf, Yi, Yf):");
            Console.Write("Xi: ");
            int xi = int.Parse(Console.ReadLine());
            Console.Write("Xf: ");
            int xf = int.Parse(Console.ReadLine());
            Console.Write("Yi: ");
            int yi = int.Parse(Console.ReadLine());
            Console.Write("Yf: ");
            int yf = int.Parse(Console.ReadLine());

            // Marcar a área coberta pela rede na matriz
            for (int x = xi; x <= xf; x++)
            {
                for (int y = yi; y <= yf; y++)
                {
                    mar[x, y] = 1; // Marca a posição como coberta
                }
            }
        }

        // Calcular a área coberta (número de células marcadas na matriz)
        int areaCoberta = 0;
        foreach (int cell in mar)
        {
            if (cell == 1)
                areaCoberta++;
        }

        // Exibir a matriz do mar (opcional, para depuração)
        Console.WriteLine("\nRepresentação do mar com áreas cobertas:");
        Matriz.Mostra(mar);

        // Exibir a área total coberta
        Console.WriteLine($"\nA área total coberta pelas redes é: {areaCoberta}");
    }
}
