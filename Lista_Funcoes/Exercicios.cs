using System;

namespace Lista_Funcoes
{
    class Exercicios
    {
        void media(char tip_med, double n1, double n2, double n3) 
        {
            double result;
            
            if(tip_med == 'A' || tip_med == 'a') 
            {
                result = (n1 + n2 + n3) / 3;
                Console.WriteLine("A média aritmética de {0}, {1}, {2} é: {3}", n1, n2, n3, result);
            }
            else if(tip_med == 'P' || tip_med == 'p') 
            {
                result = (n1 * 5 + n2 * 3 + n3 * 2) / 5 + 3 + 2;
                Console.WriteLine("A média ponderada de {0}, {1}, {2} é: {3}", n1, n2, n3, result);
            }
        }

        public static void Main(String[] args) 
        {
            Console.Write("Informe a quantidade de alunos: ");
            int quant = int.Parse(Console.ReadLine());

            for(int i = 0; i < quant; i++) 
            {
                Console.WriteLine("(A ou a) para média aritmética");
                Console.WriteLine("(A ou a) para média aritmética");

            }

        }
    }
}