using System;

namespace C_.Lista_POO
{
    public class Ex6
    {
        class Triangulo
        {
            public double lado1, lado2, lado3;

            public Triangulo(double lado1, double lado2, double lado3)
            {
                this.lado1 = lado1;
                this.lado2 = lado2;
                this.lado3 = lado3;
            }

            public Triangulo()
            {
                Console.Write("Digite o primeiro lado do triângulo: ");
                lado1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo lado do triângulo: ");
                lado2 = double.Parse(Console.ReadLine());
                Console.Write("Digite o terceiro lado do triângulo: ");
                lado3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Lado 1: {0}", lado1);
                Console.WriteLine("Lado 2: {0}", lado2);
                Console.WriteLine("Lado 3: {0}\n", lado3);
            }
        }

        /*
        static void Main(String[] args)
        {
            Triangulo triangulo = new Triangulo(3.0, 4.0, 5.0);
            Console.WriteLine("Triângulo 1:");
            Console.WriteLine("Lado 1: {0}", triangulo.lado1);
            Console.WriteLine("Lado 2: {0}", triangulo.lado2);
            Console.WriteLine("Lado 3: {0}\n", triangulo.lado3);
            Console.WriteLine("Triângulo 2:");
            Triangulo triangulo2 = new Triangulo();
        }
        */
    }
}