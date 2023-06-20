using System;

namespace C_.Lista_Enum_e_Struct
{
    public class Ex6
    {
        struct Data
        {
            public int dia, ano;
            public string mes;

            public void InicializaData(int dia, string mes, int ano)
            {
                this.dia = dia;
                this.mes = mes;
                this.ano = ano;
            }

            public void MostrarData(Data d)
            {
                Console.WriteLine("Data: {0}/{1}/{2}", d.dia, d.mes, d.ano);
            }
        }

        /*
        static void Main(String[] args)
        {
            Console.Write("Informe o dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Informe o mês: ");
            string mes = Console.ReadLine();
            Console.Write("Informe o ano: ");
            int ano = int.Parse(Console.ReadLine());

            Data data = new Data();

            data.InicializaData(dia, mes, ano);
            data.MostrarData(data);
        }
        */
    }
}