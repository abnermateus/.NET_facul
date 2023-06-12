using System;

namespace C_.Lista_POO
{
    public class Ex2
    {
        class ContaBancaria
        {
            public string titular;
            private double saldo;

            public void exibeSaldo()
            {
                Console.WriteLine("Seu saldo é: R$ {0}", saldo);
            }
            public void depositar(double valor)
            {
                saldo += valor;
            }

            public void sacar(double valor)
            {
                if (valor <= saldo)
                {
                    saldo -= valor;
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente!");
                }
            }
        }

        /*
        public static void Main(String[] args)
        {
            ContaBancaria conta = new ContaBancaria();
            conta.titular = "Abner Mateus";
            Console.WriteLine("Titular: " + conta.titular);
            conta.exibeSaldo();
            conta.depositar(50);
            conta.exibeSaldo();
            conta.sacar(50);
            conta.exibeSaldo();
            conta.sacar(50);
            conta.exibeSaldo();
        }
        */
    }
}
