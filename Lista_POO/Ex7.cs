using System;

namespace C_.Lista_POO
{
    public class Ex7
    {
        class Funcionario
        {
            public string nome;
            public string cargo;
            public double salario;

            public Funcionario(string nome, string cargo, double salario = 5000)
            {
                this.nome = nome;
                this.cargo = cargo;
                this.salario = salario;
            }
        }

        /*
        static void Main(String[] args)
        {
            Funcionario funcionario = new Funcionario("Edwaldo", "Professor");
            Console.WriteLine("Nome: " + funcionario.nome);
            Console.WriteLine("Cargo: " + funcionario.cargo);
            Console.WriteLine("Salário: " + funcionario.salario);
            Funcionario funcionario2 = new Funcionario("Edwaldo", "Professor", 10000);
            Console.WriteLine("Nome: " + funcionario2.nome);
            Console.WriteLine("Cargo: " + funcionario2.cargo);
            Console.WriteLine("Salário: " + funcionario2.salario);
        }
        */
    }
}