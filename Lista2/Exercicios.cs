using System;

namespace C_.Lista2
{
    public class Exercicios
    {
        static void Main(String[] args)
        {
            /*Ex1
            while (true)
            {
                Console.WriteLine("\n[1] Adição\n[2] Subtração\n[3] Multiplicação\n[4] Divisão\n[0] Sair");
                Console.Write("\nDigite uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    Console.WriteLine("Saindo...");
                    break;
                }
                else
                {
                    double num1, num2;

                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Informe o 1º número: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Informe o 2º número: ");
                            num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                            break;
                        case 2:
                            Console.Write("Informe o 1º número: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Informe o 2º número: ");
                            num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                            break;
                        case 3:
                            Console.Write("Informe o 1º número: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Informe o 2º número: ");
                            num2 = double.Parse(Console.ReadLine());
                            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                            break;
                        case 4:
                            Console.Write("Informe o 1º número: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Informe o 2º número: ");
                            num2 = double.Parse(Console.ReadLine());
                            if (num2 == 0)
                            {
                                Console.WriteLine("Impossível dividir por 0!");
                            }
                            else
                            {
                                Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                            }
                            break;
                        default:
                            Console.WriteLine("Opção inválida! Tente novamente!");
                            break;
                    }
                }
            }*/

            /*Ex2
            Console.Write("Informe quantos valores deseja ler: ");
            int n = int.Parse(Console.ReadLine());
            int pares = 0, impares = 0;

            while(n > 0) {
                Console.Write("Digite um número: ");
                int num = int.Parse(Console.ReadLine());

                if(num % 2 == 0) {
                    pares++;
                }
                else {
                    impares++;
                }
                n--;
            }
            Console.WriteLine("Você digitou {0} números pares e {1} números ímpares.", pares, impares);
            */
        }
    }
}


