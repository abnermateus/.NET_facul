using System;

namespace C_.Lista_POO
{
    public class Ex5
    {
        class Aluno
        {
            public string nome;
            public string matricula;
            private double[] notas;

            public void setNotas(double[] notas)
            {
                this.notas = notas;
            }

            public double calculaMedia()
            {
                double soma = 0;
                foreach (double nota in notas)
                {
                    soma += nota;
                }
                return soma / notas.Length;
            }
        }

        /*
        static void Main(String[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();
            Console.Write("Digite a matricula do aluno: ");
            aluno.matricula = Console.ReadLine();
            Console.Write("Digite a quantidade de notas do aluno: ");
            int qtdNotas = int.Parse(Console.ReadLine());
            double[] notas = new double[qtdNotas];
            for (int i = 0; i < qtdNotas; i++)
            {
                Console.Write("Digite a {0}ª nota do aluno: ", i + 1);
                notas[i] = double.Parse(Console.ReadLine());
            }
            aluno.setNotas(notas);
            Console.WriteLine("A média do aluno {0} é {1}", aluno.nome, aluno.calculaMedia());
        }
        */
    }
}