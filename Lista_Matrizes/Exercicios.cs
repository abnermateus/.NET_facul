using System;

namespace C_.Lista_Matrizes
{
    public class Exercicios
    {
        /*
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

            /*Ex2
            int[,] A = new int[4, 4];
            int soma = 0, cont_l = 0, cont_c = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Digite o elemento da linha {0} e coluna {1}: ", i, j);
                    A[i, j] = int.Parse(Console.ReadLine());
                    soma += A[i, j];
                }
                if (soma == 0)
                {
                    cont_l++;
                }
                soma = 0;
            }

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    soma += A[i, j];
                }
                if (soma == 0)
                {
                    cont_c++;
                }
                soma = 0;
            }
            Console.WriteLine("Esta matriz tem {0} linha(s) nula(s)", cont_l);
            Console.WriteLine("Esta matriz tem {0} coluna(s) nula(s)", cont_c);
            */

            /*Ex3
            Console.Write("Digite a dimensão da matriz quadrada: ");
            int t = int.Parse(Console.ReadLine());
            int[,] m = new int[t, t];

            for(int i = 0; i < t; i++)
            {
                for(int j = 0; j < t; j++)
                {
                    Console.Write("Digite o elemento da linha {0} e coluna {1}: ", i, j);
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("Os elementos da diagonal são: ");
            for(int i = 0; i < t; i++)
            {
                Console.Write("{0} ", m[i, i]);
            }
            Console.WriteLine();
            */

            /*Ex4
            Console.WriteLine("Digite a dimensão das matrizes quadradas: ");
            int t = int.Parse(Console.ReadLine());
            int[,] A = new int[t, t], B = new int[t, t], C = new int[t, t];

            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    Console.Write("Digite o elemento da linha {0} e coluna {1} da matriz A: ", i, j);
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    Console.Write("Digite o elemento da linha {0} e coluna {1} da matriz B: ", i, j);
                    B[i, j] = int.Parse(Console.ReadLine());
                    C[i, j] = A[i, j] * B[i, j];
                }
            }

            Console.Write("\nA matriz C = A * B é igual a: ");
            for (int i = 0; i < t; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < t; j++)
                {
                    Console.Write("{0} ", C[i, j]);
                }
            }
            Console.WriteLine();
        }
         */
    }
}


