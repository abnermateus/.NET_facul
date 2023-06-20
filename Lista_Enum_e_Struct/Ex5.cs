using System;

namespace C_.Lista_Enum_e_Struct
{
    public class Ex5
    {
        struct Retangulo
        {
            public double largura, altura;

            public double Area()
            {
                return largura * altura;
            }
        }

        /*
        static void Main(String[] args)
        {
            Retangulo r;
            Console.Write("Informe a largura do retângulo: ");
            r.largura = double.Parse(Console.ReadLine());
            Console.Write("Informe a altura do retângulo: ");
            r.altura = double.Parse(Console.ReadLine());

            Console.WriteLine("A área do retângulo é {0}", r.Area());
        }
        */
    }
}