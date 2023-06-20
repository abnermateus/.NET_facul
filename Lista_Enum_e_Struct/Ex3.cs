using System;

namespace C_.Lista_Enum_e_Struct
{
    public class Ex3
    {
        enum OperacaoMatematica { Soma = 1, Subtracao, Multiplicacao, Divisao };

        static int EscolheOperacao()
        {
            Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");
            Console.Write("\nEscolha uma operação: ");
            int opcao = int.Parse(Console.ReadLine());
            return opcao;
        }

        /*
        static void Main(String[] args)
        {
            int opcao = EscolheOperacao();

            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case (int)OperacaoMatematica.Soma:
                    Console.WriteLine("A soma de {0} e {1} é {2}", num1, num2, num1 + num2);
                    break;
                case (int)OperacaoMatematica.Subtracao:
                    Console.WriteLine("A subtração de {0} e {1} é {2}", num1, num2, num1 - num2);
                    break;
                case (int)OperacaoMatematica.Multiplicacao:
                    Console.WriteLine("A multiplicação de {0} e {1} é {2}", num1, num2, num1 * num2);
                    break;
                case (int)OperacaoMatematica.Divisao:
                    Console.WriteLine("A divisão de {0} e {1} é {2}", num1, num2, num1 / num2);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        */
    }
}