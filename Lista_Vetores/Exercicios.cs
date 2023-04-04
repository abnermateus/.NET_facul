using System;

namespace Lista_Vetores
{
    class Exercicios
    {
        /*
        public static void Main(String[] args)
        {
            /*Ex1
            int[] a = new int[5], b = new int[5];
            int produto = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o {0}º elemento do arranjo a: ", i+1);
                a[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o {0}º elemento do arranjo b: ", i+1);
                b[i] = int.Parse(Console.ReadLine());

                produto += a[i] * b[i];
            }
            Console.WriteLine("O produto escalar de a[] por b[] é: " + produto);
            */

            /*Ex2
            int[] v = new int[5];
            int menor, aux;
            Console.WriteLine("Digite 5 valores");
            
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Informe o {0}º valor: ", i + 1);
                v[i] = int.Parse(Console.ReadLine());
                menor = v[0];

                if(v[i] < menor)
                {
                    menor = v[i];
                    aux = v[0];
                    v[0] = v[i];
                    v[i] = aux;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write(v[i] + " ");
            }
           */

            /*Ex3
            double[] v1 = new double[5], v2 = new double[5];
            Console.WriteLine("Digite 5 valores reais");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Informe o {0}º valor: ", i + 1);
                v1[i] = double.Parse(Console.ReadLine());

                v2[i] = v1[i] * 3;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} ", v1[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} ", v2[i]);
            }
            */

            /*Ex4
            int[] v = new int[10];
            int menor = 0, maior = 0;
            double media = 0;
            Console.WriteLine("Informe 10 números");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o {0}º número: ", i + 1);
                v[i] = int.Parse(Console.ReadLine());

                menor = v[0];
                maior = v[0];
                media += v[i];
            }

            for (int i = 0; i < 10; i++)
            {
                if (v[i] < menor)
                {
                    menor = v[i];
                }

                if (v[i] > maior)
                {
                    maior = v[i];
                }
            }

            media /= 10;

            Console.WriteLine("O menor elemento da sequência é o {0}.", menor);
            Console.WriteLine("O maior elemento da sequência é o {0}.", maior);
            Console.WriteLine("A média dos elementos é {0}.", media);
        }
         */
    }
}



