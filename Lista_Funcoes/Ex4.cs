using System;

namespace C_.Lista_Funcoes
{
    public class Ex4
    {
        /*
        static void Main(String[] args)
        {
            double l1, l2, l3;

            do
            {
                Console.Write("Informe o 1º lado do triângulo ou 0 para sair: ");
                l1 = double.Parse(Console.ReadLine());

                if (l1 == 0)
                {
                    break;
                }
                Console.Write("Informe o 2º lado do triângulo ou 0 para sair: ");
                l2 = double.Parse(Console.ReadLine());
                if (l2 == 0)
                {
                    break;
                }
                Console.Write("Informe o 3º lado do triângulo ou 0 para sair: ");
                l3 = double.Parse(Console.ReadLine());
                if (l3 == 0)
                {
                    break;
                }
                triangulo(l1, l2, l3);
            } while (l1 != 0 || l2 != 0 || l3 != 0);
        }

        static void triangulo(double l1, double l2, double l3)
        {
            if (l1 < l2 + l3 && l2 < l1 + l3 && l3 < l1 + l2)
            {
                if (l1 == l2 && l2 == l3)
                {
                    Console.WriteLine("Triângulo equilátero");
                }
                else if (l1 == l2 || l2 == l3 || l1 == l3)
                {
                    Console.WriteLine("Triângulo isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo escaleno");
                }
            }
            else
            {
                Console.WriteLine("Não é um triângulo");
            }
        }
        */
    }
}