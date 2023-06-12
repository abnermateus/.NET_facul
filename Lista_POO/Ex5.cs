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

        static void Main(String[] args)
        {

        }
    }
}