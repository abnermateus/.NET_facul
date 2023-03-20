using System;

namespace C_.Lista1
{
    public class Exercicios
    {
        static void Main(String[] args)
        {
            /*Ex1 
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("A raiz do número " + num + " é " + Math.Sqrt(num));
            }
            else
            {
                Console.WriteLine("Número inválido!");
            }
            */

            /*Ex2 
            int num1, num2, num3, num4, num5, maior, menor;
            Console.Write("Digite o 1º valor: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 3º valor: ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 4º valor: ");
            num4 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 5º valor: ");
            num5 = int.Parse(Console.ReadLine());

            maior = num1;
            if (num2 > maior)
            {
                maior = num2;
            }
            if (num3 > maior)
            {
                maior = num3;
            }
            if (num4 > maior)
            {
                maior = num4;
            }
            if (num5 > maior)
            {
                maior = num5;
            }

            menor = num1;
            if (num2 < menor)
            {
                menor = num2;
            }
            if (num3 < menor)
            {
                menor = num3;
            }
            if (num4 < menor)
            {
                menor = num4;
            }
            if (num5 < menor)
            {
                menor = num5;
            }

            Console.WriteLine("O maior número é " + maior + " e o menor é " + menor);
            */

            /*Ex3
            Console.Write("Digite o 1º valor: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            int b = int.Parse(Console.ReadLine());
            int aux;

            if(a != b) {
                aux = a;
                a = b;
                b = aux;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else {
                Console.WriteLine("Os valores são iguais, impossível fazer troca!");
            }
            */

            /*Ex4
            Console.Write("Digite 'M' para sexo masculino ou 'F' para sexo feminino: ");
            char opcao = char.Parse(Console.ReadLine());
            double altura;

            switch (opcao)
            {
                case 'M':
                    Console.Write("Informe sua altura: ");
                    altura = double.Parse(Console.ReadLine());
                    double pesom = (72.7 * altura) - 58;
                    Console.WriteLine("O peso ideal é " + pesom);
                    break;
                case 'F':
                    altura = double.Parse(Console.ReadLine());
                    double pesof = (62.1 * altura) - 44.7;
                    Console.WriteLine("O peso ideal é " + pesof);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            */

            /*Ex5
            Console.Write("Informe um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 0 || num > 999) {
                Console.WriteLine("Número inválido");
            }
            else {
                int unidade = num % 10;
                int dezena = (num / 10) % 10;
                int centena = num / 100;
                Console.WriteLine(unidade);
                Console.WriteLine(dezena);
                Console.WriteLine(centena);
                Console.WriteLine("A soma dos algarismos é: " + (unidade + dezena + centena));
            }
            */

            /*Ex6
            Console.WriteLine("(+) Soma");
            Console.WriteLine("(-) Subtração");
            Console.WriteLine("(*) Multiplicação ");
            Console.WriteLine("(/) Divisão");
            Console.Write("\nEscolha uma opção: ");
            char opcao = char.Parse(Console.ReadLine());

            Console.Write("Digite os dois valores: ");
            double val1 = double.Parse(Console.ReadLine());
            double val2 = double.Parse(Console.ReadLine());

            switch (opcao)
            {
                case '+':
                    Console.WriteLine(val1 + " + " + val2 + " = " + (val1 + val2));
                    break;
                case '-':
                    if (val1 > val2)
                    {
                        Console.WriteLine(val1 + " - " + val2 + " = " + (val1 - val2));
                    }
                    else
                    {
                        Console.WriteLine(val2 + " - " + val1 + " = " + (val2 - val1));
                    }
                    break;
                case '*':
                    Console.WriteLine(val1 + " * " + val2 + " = " + (val1 * val2));
                    break;
                case '/':
                    if (val2 == 0)
                    {
                        Console.WriteLine("Impossível dividir por 0!");
                    }
                    else
                    {
                        Console.WriteLine(val1 + " / " + val2 + " = " + (val1 / val2));
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            */

            /*Ex7
            Console.Write("Digite o código do produto: ");
            int cod = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade: ");
            double quant = double.Parse(Console.ReadLine());

            switch (cod)
            {
                case 100:
                    Console.WriteLine("O valor gasto com Cachorro Quente é: R$ " + quant * 1.20);
                    break;
                case 101:
                    Console.WriteLine("O valor gasto com Bauru Simples é: R$ " + quant * 1.30);
                    break;
                case 102:
                    Console.WriteLine("O valor gasto com Bauru com Ovo é: R$ " + quant * 1.50);
                    break;
                case 103:
                    Console.WriteLine("O valor gasto com Hamburguer é: R$ " + quant * 1.20);
                    break;
                case 104:
                    Console.WriteLine("O valor gasto com Cheeseburguer é: R$ " + quant * 1.70);
                    break;
                case 105:
                    Console.WriteLine("O valor gasto com Suco é: R$ " + quant * 2.20);
                    break;
                case 106:
                    Console.WriteLine("O valor gasto com Refrigerante é: R$ " + quant * 1);
                    break;
                default:
                    Console.WriteLine("Código inválido!");
                    break;
            }
            */

            /*Ex8
            Console.Write("Informe seu peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Informe sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            double IMC = peso / (altura * altura);

            if (IMC < 18.5)
            {
                Console.WriteLine("Seu IMC é " + IMC + ". Você está abaixo do peso!");
            }
            else if (IMC > 18.5 && IMC < 25)
            {
                Console.WriteLine("Seu IMC é " + IMC + ". Você está saudável!");
            }
            else if (IMC > 24.9 && IMC < 30)
            {
                Console.WriteLine("Seu IMC é " + IMC + ". Você está com peso em excesso!");
            }
            else if (IMC > 29.9 && IMC < 35)
            {
                Console.WriteLine("Seu IMC é " + IMC + ". Você está em Obesidade grau I!");
            }
            else if (IMC > 34.9 && IMC < 40)
            {
                Console.WriteLine("Seu IMC é " + IMC + ". Você está em Obesidade grau II (severa)!");
            }
            else if (IMC >= 40)
            {
                Console.WriteLine("Seu IMC é " + IMC + ". Você está em Obesidade grau III (mórbida)!");
            }
            */

            /*Ex9
            Console.Write("Informe um ano: ");
            int ano = int.Parse(Console.ReadLine());

            if (ano % 400 == 0 || ano % 4 == 0 && ano % 100 != 0)
            {
                Console.WriteLine("O ano é bissexto!");
            }
            else
            {
                Console.WriteLine("O ano não é bissexto!");
            }
            */
        }
    }
}