using System;
using System.Text;
using System.IO;
namespace C_.Lista_Arquivos
{
    public class Exercicios
    {
        static void Main()
        {
            string arquivoEntrada = "C:/Users/Abner/Documents/GitHub/CSharp_PUC-MG/Lista_Arquivos/alunos.txt";
            string arquivoSaidaMediaSuperior = "C:/Users/Abner/Documents/GitHub/CSharp_PUC-MG/Lista_Arquivos/medias_superiores.txt";
            string arquivoSaidaMediaInferior = "C:/Users/Abner/Documents/GitHub/CSharp_PUC-MG/Lista_Arquivos/medias_inferiores.txt";
            string arquivoSaidaOrdemDecrescente = "C:/Users/Abner/Documents/GitHub/CSharp_PUC-MG/Lista_Arquivos/ordem_decrescente.txt";

            string[] linhas = File.ReadAllLines(arquivoEntrada);
            int quantidadeLinhas = linhas.Length;

            string[] nomes = new string[quantidadeLinhas];
            double[,] notas = new double[quantidadeLinhas, 3];


            for (int i = 0; i < quantidadeLinhas; i++)
            {
                string[] campos = linhas[i].Split();

                nomes[i] = campos[0];

                for (int j = 0; j < 3; j++)
                {
                    notas[i, j] = double.Parse(campos[j + 1]);
                }
            }

            double[] medias = CalcularMedias(notas);
            EscreverMediasSuperiores(arquivoSaidaMediaSuperior, nomes, medias);
            EscreverMediasInferiores(arquivoSaidaMediaInferior, nomes, medias);
            EscreverOrdemDecrescente(arquivoSaidaOrdemDecrescente, nomes, medias);

            double maiorNota = ObterMaiorNota(notas);
            Console.WriteLine("Maior nota geral: " + maiorNota);
            ImprimirDadosEstudantes(nomes, medias);
        }

        static double[] CalcularMedias(double[,] notas)
        {
            int quantidadeEstudantes = notas.GetLength(0);
            double[] medias = new double[quantidadeEstudantes];

            for (int i = 0; i < quantidadeEstudantes; i++)
            {
                double soma = 0.0;

                for (int j = 0; j < 3; j++)
                {
                    soma += notas[i, j];
                }

                medias[i] = soma / 3.0;
            }

            return medias;
        }

        static void EscreverMediasSuperiores(string arquivoSaida, string[] nomes, double[] medias)
        {
            using (StreamWriter writer = new StreamWriter(arquivoSaida))
            {
                for (int i = 0; i < nomes.Length; i++)
                {
                    if (medias[i] >= 6.0)
                    {
                        writer.WriteLine(nomes[i] + " " + medias[i]);
                    }
                }
            }
        }

        static void EscreverMediasInferiores(string arquivoSaida, string[] nomes, double[] medias)
        {
            using (StreamWriter writer = new StreamWriter(arquivoSaida))
            {
                for (int i = 0; i < nomes.Length; i++)
                {
                    if (medias[i] < 6.0)
                    {
                        writer.WriteLine(nomes[i] + " " + medias[i]);
                    }
                }
            }
        }

        static void EscreverOrdemDecrescente(string arquivoSaida, string[] nomes, double[] medias)
        {
            Array.Sort(medias, nomes);
            Array.Reverse(nomes);
            Array.Reverse(medias);

            using (StreamWriter writer = new StreamWriter(arquivoSaida))
            {
                for (int i = 0; i < nomes.Length; i++)
                {
                    writer.WriteLine(nomes[i] + " " + medias[i]);
                }
            }
        }
        static double ObterMaiorNota(double[,] notas)
        {
            double maiorNota = double.MinValue;

            int quantidadeEstudantes = notas.GetLength(0);
            int quantidadeNotas = notas.GetLength(1);

            for (int i = 0; i < quantidadeEstudantes; i++)
            {
                for (int j = 0; j < quantidadeNotas; j++)
                {
                    if (notas[i, j] > maiorNota)
                    {
                        maiorNota = notas[i, j];
                    }
                }
            }
            return maiorNota;
        }
        static void ImprimirDadosEstudantes(string[] nomes, double[] medias)
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nome: " + nomes[i] + ", Média: " + medias[i]);
            }
        }
    }
}


