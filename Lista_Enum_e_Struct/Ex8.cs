using System;

namespace C_.Lista_Enum_e_Struct
{
    public class Ex8
    {
        enum DiaSemana { Domingo = 1, Segunda, Terca, Quarta, Quinta, Sexta, Sabado};

        struct Agenda
        {
            public DiaSemana dia;
            public string[] tarefas;

            public void ListarTarefas()
            {
                Console.WriteLine("Tarefas do {0}:", dia);
                foreach (string tarefa in tarefas)
                {
                    Console.WriteLine(tarefa);
                }
            }
        }

        /*
        static void Main(String[] args)
        {
            Agenda agenda;
            Console.Write("Informe o dia da semana: ");
            agenda.dia = (DiaSemana)int.Parse(Console.ReadLine());
            Console.WriteLine("Informe as tarefas do dia:");
            agenda.tarefas = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Tarefa {0}: ", i + 1);
                agenda.tarefas[i] = Console.ReadLine();
            }
            agenda.ListarTarefas();
        }
        */
    }
}