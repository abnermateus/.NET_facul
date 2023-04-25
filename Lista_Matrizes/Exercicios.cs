using System;

namespace C_.Lista_Matrizes
{
    public class Exercicios
    {
        static void Main(String[] args)
        {
            /*Ex1
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
            */

            //Dada uma matriz A[4x4], imprimir o número de linhas e o número de colunas nulas (com apenas 
            //0s) da matriz. Uma estrutura de repetição deve ser utilizada para percorrer as linhas e colunas.
            int[,] A = new int[4, 4];
            int soma_total = 0, cont_linha = 0, cont_coluna = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Digite o elemento da linha {0} e coluna {1}: ", i, j);
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    soma_total += A[i, j];
                }
                if (soma_total == 0)
                {
                    cont_linha++;
                }
                soma_total = 0;
            }
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    soma_total += A[i, j];
                }
                if (soma_total == 0)
                {
                    cont_coluna++;
                }
                soma_total = 0;
            }
            Console.WriteLine("O número de linhas nulas é {0} e o número de colunas nulas é {1}", cont_linha, cont_coluna);
        }
    }
}


