using System;

namespace C_.Lista_POO
{
    public class Ex3
    {
        class Livro 
        {
            public string titulo;
            public string autor;
            public string genero;
            public int anoPublicacao;
        
            public void info()
            {
                Console.WriteLine("Título: {0}", titulo);
                Console.WriteLine("Autor: {0}", autor);
                Console.WriteLine("Gênero: {0}", genero);
                Console.WriteLine("Ano de publicação: {0}", anoPublicacao);
            }

            public Boolean ehFiccao()
            {
                if (genero == "Ficção")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /*
        static void Main(String[] args)
        {
            Livro livro1 = new Livro();
            livro1.titulo = "O Senhor dos Anéis";
            livro1.autor = "J. R. R. Tolkien";
            livro1.genero = "Ficção";
            livro1.anoPublicacao = 1954;
            livro1.info();
            Console.WriteLine("É ficção? {0}\n", livro1.ehFiccao());
            Livro livro2 = new Livro();
            livro2.titulo = "Diário de Anne Frank";
            livro2.autor = "Anne Frank";
            livro2.genero = "Biografia";
            livro2.anoPublicacao = 1947;
            livro2.info();
            Console.WriteLine("É ficção? {0}", livro2.ehFiccao());
        }
        */
    }
}