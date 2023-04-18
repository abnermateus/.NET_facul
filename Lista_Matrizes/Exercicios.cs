using System;

namespace Lista_Matrizes
{
    class Exercicios
    {
       static void Main(string[] args)
        {
            
             int[,] m = new int[4, 5];
            int soma = 0, soma_total = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("Digite o elemento da linha {0} e coluna {1}: ", i, j);
                    m[i, j] = int.Parse(Console.ReadLine());
                }

            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    soma += m[i, j];
                }
                Console.WriteLine("A soma da linha {0} é igual a {1}", i, soma);
                soma_total += soma;
                soma = 0;
            }

            Console.WriteLine("A soma de todos os elementos é {0}", soma_total);    
            
        }
    }
}