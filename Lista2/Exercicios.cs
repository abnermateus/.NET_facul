using System;

namespace C_.Lista2
{
    public class Exercicios
    {
        static void Main(String[] args)
        {
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
                            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                            break;
                        default:
                            Console.WriteLine("Opção inválida! Tente novamente!");
                            break;
                    }
                }
            }
        }
    }
}


