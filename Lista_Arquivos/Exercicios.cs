using System;
using System.Text;
using System.IO;

namespace C_.Lista_Arquivos
{
    public class Exercicios
    {
        static void Main(String[] args)
        {
            string caminho = "Lista_Arquivos\\alunos.txt";
            int cont = tamanhoArquivo(caminho);
            string[] nomes = new string[cont];
            double[] medias = new double[cont];

            armazenaNomes(nomes, caminho);
            armazenaMedias(medias, caminho);
            //mediaSuperiorOuIgual(nomes, medias);
            //mediaInferior(nomes, medias);
            //mediaDecrescente(nomes, medias);
            //maiorNota(caminho);
            imprimeDados(nomes, medias);
        }
        static int tamanhoArquivo(string caminho)
        {
            int cont = 0;

            try
            {
                StreamReader arq = new StreamReader(caminho, Encoding.UTF8);
                string linha = arq.ReadLine();

                do
                {
                    cont++;
                    linha = arq.ReadLine();
                } while (linha != null);
                arq.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            return cont;
        }

        static void armazenaNomes(string[] nomes, string caminho)
        {
            try
            {
                StreamReader arq = new StreamReader(caminho, Encoding.UTF8);
                string linha = arq.ReadLine();
                string[] dados;
                int i = 0;

                do
                {
                    dados = linha.Split();
                    nomes[i] = dados[1];
                    linha = arq.ReadLine();
                    i++;
                } while (linha != null);
                arq.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        static void armazenaMedias(double[] medias, string caminho)
        {
            try
            {
                StreamReader arq = new StreamReader(caminho, Encoding.UTF8);
                string linha = arq.ReadLine();
                string[] dados;
                int i = 0;

                do
                {
                    dados = linha.Split();
                    double nota1 = double.Parse(dados[2]) / 10.0;
                    double nota2 = double.Parse(dados[3]) / 10.0;
                    double nota3 = double.Parse(dados[4]) / 10.0;
                    medias[i] = Math.Round(((nota1 + nota2 + nota3) / 3.0), 2);
                    linha = arq.ReadLine();
                    i++;
                } while (linha != null);
                arq.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        static void mediaSuperiorOuIgual(string[] nomes, double[] medias)
        {
            StreamWriter arq = new StreamWriter("Lista_Arquivos\\mediaSuperiorOuIgual.txt", false, Encoding.UTF8);
            for (int i = 0; i < medias.Length; i++)
            {
                if (medias[i] >= 6.0)
                {
                    arq.WriteLine(nomes[i] + " " + medias[i]);
                }
            }
            arq.Close();
        }

        static void mediaInferior(string[] nomes, double[] medias)
        {
            StreamWriter arq = new StreamWriter("Lista_Arquivos\\mediaInferior.txt", false, Encoding.UTF8);
            for (int i = 0; i < medias.Length; i++)
            {
                if (medias[i] < 6.0)
                {
                    arq.WriteLine(nomes[i] + " " + medias[i]);
                }
            }
            arq.Close();
        }

        static void mediaDecrescente(string[] nomes, double[] medias)
        {
            StreamWriter arq = new StreamWriter("Lista_Arquivos\\mediaDecrescente.txt", false, Encoding.UTF8);
            for (int i = 0; i < medias.Length; i++)
            {
                for (int j = i + 1; j < medias.Length; j++)
                {
                    if (medias[i] < medias[j])
                    {
                        double aux = medias[i];
                        medias[i] = medias[j];
                        medias[j] = aux;

                        string aux2 = nomes[i];
                        nomes[i] = nomes[j];
                        nomes[j] = aux2;
                    }
                }
            }
            for (int i = 0; i < medias.Length; i++)
            {
                arq.WriteLine(nomes[i] + " " + medias[i]);
            }
            arq.Close();
        }

        /*
        static void maiorNota(string caminho)
        {
            double maior;

            try
            {
                StreamReader arq = new StreamReader(caminho, Encoding.UTF8);
                string linha = arq.ReadLine();
                string[] dados;

                do
                {
                    dados = linha.Split();
                    double nota1 = double.Parse(dados[2]) / 10.0;
                    double nota2 = double.Parse(dados[3]) / 10.0;
                    double nota3 = double.Parse(dados[4]) / 10.0;
                
                    maior = nota1;

                    if (nota2 > maior)
                    {
                        maior= nota2;
                    }
                    if (nota3 > maior)
                    {
                        maior = nota3;
                    }
                    linha = arq.ReadLine();
                } while (linha != null);
                arq.Close();
                Console.WriteLine("Maior nota: " + maior);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
        */

        static void imprimeDados(string[] nomes, double[] medias)
        {
            for (int i = 0; i < medias.Length; i++)
            {
                Console.WriteLine(nomes[i] + " " + medias[i]);
            }
        }

    }
}
