using System;

namespace Lista_Matrizes
{
    class Exercicios
    {
       static void Main(string[] args)
        {
            int[,] m = new int[4, 5];

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write("Digite o elemento da linha {0} e coluna {1}: ", i, j);
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}