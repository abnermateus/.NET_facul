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
            lerArquivo(caminho);
            
        }

        static int lerArquivo(string caminho)
        {
            int cont = 0;
            try
            {
                StreamReader arq = new StreamReader(caminho, Encoding.UTF8);
                string linha = arq.ReadLine();
                while (linha != null)
                {
                    cont++;
                    linha = arq.ReadLine();
                }
                arq.Close();
                return cont;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            return 0;
        }
    }
}


