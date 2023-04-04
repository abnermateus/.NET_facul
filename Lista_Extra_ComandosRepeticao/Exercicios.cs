using System;

namespace C_.Lista_Extra_ComandosRepeticao
{
    public class Exercicios
    {
        /*
        static void Main(String[] args)
        {
            /*EX1
             Console.Write("Digite um valor limite: ");
             int n = int.Parse(Console.ReadLine()), n_copia = n;
             int positivos = 0, negativos = 0, nulos = 0;
             double media = 0;

             while(n > 0)
             {
                 Console.Write("Informe um número: ");
                 int valores = int.Parse(Console.ReadLine());

                 if(valores > 0)
                 {
                     positivos++;
                 }
                 else if(valores < 0)
                 {
                     negativos++;
                 }
                 else
                 {
                     nulos++;
                 }

                 media += valores ;

                 n--;
             }
             Console.WriteLine("O número de positivos é: " + positivos);
             Console.WriteLine("O número de negativos é: " + negativos);
             Console.WriteLine("O número de nulos é: " + nulos);
             Console.WriteLine("A média é: " + media / n_copia);
            */

        /*EX3
        Console.Write("Informe um número limite: ");
        int n = int.Parse(Console.ReadLine()), div2 = 0, div3 = 0, div5 = 0, div6 = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Informe um número: ");
            int valores = int.Parse(Console.ReadLine());

            if (valores % 2 == 0)
            {
                div2++;
            }
            if (valores % 3 == 0)
            {
                div3++;
            }
            if (valores % 5 == 0)
            {
                div5++;
            }
            if (valores % 6 == 0)
            {
                div6++;
            }
        }

        if (div2 == 0 && div3 == 0 && div5 == 0 && div6 == 0)
        {
            Console.WriteLine("Número não é divisível pelos valores!");
        }
        else
        {
            Console.WriteLine("A quantidade números divisíveis por 2 é: " + div2);
            Console.WriteLine("A quantidade números divisíveis por 3 é: " + div3);
            Console.WriteLine("A quantidade números divisíveis por 5 é: " + div5);
            Console.WriteLine("A quantidade números divisíveis por 6 é: " + div6);
        }
        */

        /*EX7
       Console.Write("Informe um valor limite: ");
       int n = int.Parse(Console.ReadLine()), f1 = 1, f2 = 0, f3;
       Console.Write("0 ");

       for(int i = 1; i < n; i++)
       {
           Console.Write(f1 + " ");
           f3 = f1 + f2;
           f2 = f1;
           f1 = f3;
       }
    }*/
    }
}

