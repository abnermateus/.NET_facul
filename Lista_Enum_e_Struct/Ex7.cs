using System;

namespace C_.Lista_Enum_e_Struct
{
    public class Ex7
    {
        struct TimeFutebol
        {
            public string nome;
            public string[] jogadores;

            public void ListarJogadores()
            {
                Console.WriteLine("Jogadores do {0}:", nome);
                foreach (string jogador in jogadores)
                {
                    Console.WriteLine("\n" + jogador);
                }
            }
        }

        /*
        static void Main(String[] args)
        {
            TimeFutebol time;
            Console.Write("Informe o nome do time: ");
            time.nome = Console.ReadLine();
            Console.WriteLine("Informe os nomes dos jogadores:");
            time.jogadores = new string[11];

            for (int i = 0; i < 11; i++)
            {
                Console.Write("Jogador {0}: ", i + 1);
                time.jogadores[i] = Console.ReadLine();
            }
            time.ListarJogadores();
        }
        */
    }
}