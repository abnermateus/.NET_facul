using System;

namespace C_.Lista_Strings
{
    public class Exercicios
    {
        /*
        static void Main(String[] args)
        {
            /*Ex1
            string str1, str2, maior = "";
            Console.Write("Digite a primeira string: ");
            str1 = Console.ReadLine();
            Console.Write("Digite a segunda string: ");
            str2 = Console.ReadLine();

            if (str1.Equals(str2))
            {
                Console.WriteLine("\nStrings iguais");
            }
            else
            {
                if (str1.Length > str2.Length)
                {
                    maior = str1;
                }
                else
                {
                    maior = str2;
                }
                Console.WriteLine("Maior string: " + maior);
                Console.WriteLine("Strings concatenadas: " + str1 + str2);
                Console.WriteLine("Strings concatenadas: " + str2 + str1);
            }
            */

            /*Ex2
            Console.Write("Digite uma string: ");
            string str = Console.ReadLine();
            Console.Write("Digite um caracter: ");
            char c = char.Parse(Console.ReadLine());
            int cont = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    cont++;
                }
            }
            Console.WriteLine("O caracter {0} aparece {1} vez(es) na string {2}", c, cont, str);
            */

            /*Ex3
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();
            string nomeCompleto = nome + " " + sobrenome;
            Console.WriteLine("Nome completo: " + nomeCompleto);
            Console.WriteLine("Número de caracteres: " + nomeCompleto.Length);
            Console.WriteLine("Primeira letra: " + nomeCompleto[0]);
            Console.WriteLine("Última letra: " + nomeCompleto[nomeCompleto.Length - 1]);
            */

            /*Ex4
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            string[] palavras = frase.Split(' ');
            Console.WriteLine("Iniciais: ");
            for (int i = 0; i < palavras.Length; i++)
            {
                Console.Write(palavras[i][0]);
            }
            Console.WriteLine();
            */

            /*Ex5
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            for (int i = frase.Length - 1; i >= 0; i--)
            {
                Console.Write(frase[i]);
            }
            Console.WriteLine();
        }
        */
    }  
}
