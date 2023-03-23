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
            }
            */

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

            /*Ex3
            Console.Write("Quantas idades deseja digitar? ");
            double n = double.Parse(Console.ReadLine()), n_copia = n;
            int element = 1, idade, cont15 = 0, cont30 = 0, cont45 = 0, cont60 = 0, cont61 = 0;

            while (n > 0)
            {
                Console.Write("Digite a idade da pessoa {0}: ", element);
                idade = int.Parse(Console.ReadLine());
                if (idade > 0 && idade < 16)
                {
                    cont15++;
                }
                else if (idade > 15 && idade < 31)
                {
                    cont30++;
                }
                else if (idade > 30 && idade < 46)
                {
                    cont45++;
                }
                else if (idade > 45 && idade < 61)
                {
                    cont60++;
                }
                else if (idade > 60)
                {
                    cont61++;
                }
                element++;
                n--;
            }
            Console.WriteLine("\nFaixa etária de 1 - 15 anos:  " + (cont15 / n_copia) * 100 + "%");
            Console.WriteLine("Faixa etária de 16 - 30 anos:  " + (cont30 / n_copia) * 100 + "%");
            Console.WriteLine("Faixa etária de 31 - 45 anos:  " + (cont45 / n_copia) * 100 + "%");
            Console.WriteLine("Faixa etária de 46 - 60 anos:  " + (cont60 / n_copia) * 100 + "%");
            Console.WriteLine("Faixa etária de  mais 60 anos:  " + (cont61 / n_copia) * 100 + "%");
            */

            /*Ex4
            Console.Write("Informe um número: ");
            int num = int.Parse(Console.ReadLine()), divisores = 0, i = 1;

            while (i <= num)
            {
                if (num % i == 0)
                {
                    divisores++;
                }
                i++;
            }

            if (divisores != 2)
            {
                Console.WriteLine("Não é primo!");
            }
            else
            {
                Console.WriteLine("É primo!");
            }
            */

        }
    }
}


