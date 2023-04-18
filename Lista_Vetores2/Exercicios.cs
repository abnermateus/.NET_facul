using System;

namespace C_.Lista_Vetores2
{
    public class Exercicios
    {
        /*
        public static void Main(String[] args)
        {
            /*Ex1
            Console.WriteLine("Informe 8 números para preencher o vetor");
            int[] v = new int[8];

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("Informe o {0}º número: ", i + 1);
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nInforme uma posição do vetor: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Informe outra posição do vetor: ");
            int Y = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 0; i < v.Length; i++)
            {
                if (X > 7 || X < 0 || Y > 7 || Y < 0)
                {
                    Console.WriteLine("Uma ou mais posições fora do limite do vetor!");
                    return;
                }
                soma = v[X] + v[Y];
            }
            Console.WriteLine("A soma dos valores encontrados nas posições {0} e {1} é: {2}", X, Y, soma);
            */

            /*Ex2
            Console.WriteLine("Informe 10 números para preencher o vetor");
            int[] v = new int[10];

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("Informe o {0}º número: ", i + 1);
                v[i] = int.Parse(Console.ReadLine());
            }

            int maior = v[0], menor = v[0];

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > maior)
                {
                    maior = v[i];
                }

                if (v[i] < menor)
                {
                    menor = v[i];
                }
            }
            Console.WriteLine("O menor elemento do vetor é {0} e o maior elemento é {1}", menor, maior);
            */

            /*Ex3
            int[] v = new int[50];

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = (i + 5 * i)  %  (i + 1); 
            }

            Console.WriteLine("O vetor preenchido é:");

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();
            */

            /*Ex4
            int[] A = new int[10], B = new int[10], C = new int[10];

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Digite o {0}º número do vetor A: ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < B.Length; i++)
            {
                Console.Write("Digite o {0}º número do vetor B: ", i + 1);
                B[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nC[10]: ");

            for (int i = 0; i < C.Length; i++)
            {
                C[i] = A[i] - B[i];
                Console.Write(C[i] + " ");
            }
            Console.WriteLine();
            */

            /*Ex5
            int[] v = new int[100];
            int cont = 0;

            for (int i = 0; cont < 100; i++)
            {
                if (i % 7 != 0 && i % 10 != 7)
                {
                    v[cont] = i;
                    cont++;
                }
            }

            Console.WriteLine("O vetor é composto por: ");

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();
            */

            /*Ex6
            int[] x = new int[5], y = new int[5], s = new int[5], p = new int[5], d = new int[5];

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write("Digite o {0}º número do vetor x: ", i + 1);
                x[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < y.Length; i++)
            {
                Console.Write("Digite o {0}º número do vetor y: ", i + 1);
                y[i] = int.Parse(Console.ReadLine());

                s[i] = x[i] + y[i];
                p[i] = x[i] * y[i];
                d[i] = x[i] - y[i];
            }

            Console.Write("\nX[i]: ");

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }

            Console.Write("\nY[i]: ");

            for (int i = 0; i < y.Length; i++)
            {
                Console.Write(y[i] + " ");
            }

            Console.Write("\nSoma[i]: ");

            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }

            Console.Write("\nProduto[i]: ");

            for (int i = 0; i < p.Length; i++)
            {
                Console.Write(p[i] + " ");
            }

            Console.Write("\nDiferença[i]: ");

            for (int i = 0; i < d.Length; i++)
            {
                Console.Write(d[i] + " ");
            }
            Console.WriteLine();
        } */
    }
}