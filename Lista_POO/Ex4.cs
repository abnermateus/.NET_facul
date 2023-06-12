using System;

namespace C_.Lista_POO
{
    public class Ex4
    {
        class Animal
        {
            public string nome;
            public int idade;
            public string classificacao;

            public void emiteSom()
            {
                switch (classificacao)
                {
                    case "cachorro":
                        Console.WriteLine("Au au");
                        break;
                    case "gato":
                        Console.WriteLine("Miau");
                        break;
                    case "papagaio":
                        Console.WriteLine("Loro quer biscoito");
                        break;
                    case "vaca":
                        Console.WriteLine("Muuu");
                        break;
                    case "cavalo":
                        Console.WriteLine("Hin in in");
                        break;
                    case "galinha":
                        Console.WriteLine("Có có có");
                        break;
                    case "pato":
                        Console.WriteLine("Quack");
                        break;
                    case "porco":
                        Console.WriteLine("Oinc oinc");
                        break;
                    case "ovelha":
                        Console.WriteLine("Bééé");
                        break;
                    default:
                        Console.WriteLine("Animal não cadastrado");
                        break;
                }
            }
        }

        /*
        static void Main(String[] args)
        {
            Animal animal = new Animal();
            Console.Write("Digite o nome do animal: ");
            animal.nome = Console.ReadLine();
            Console.Write("Digite a idade do animal: ");
            animal.idade = int.Parse(Console.ReadLine());
            Console.Write("Digite qual tipo é o animal: ");
            animal.classificacao = Console.ReadLine();
            Console.WriteLine("O animal {0} tem {1} anos e é um(a) {2}", animal.nome, animal.idade, animal.classificacao);
            Console.Write("O som que o animal {0} emite é: ", animal.nome);
            animal.emiteSom();
        }
        */
    }
}