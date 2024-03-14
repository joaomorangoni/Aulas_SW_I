using System.ComponentModel;

namespace ContaBancaria
{
    internal class Program
    { 
        static void Main(string[] args) 
        {
        Console.WriteLine("BANCO ETEC MCM");

        Conta conta = new Conta();
        Console.WriteLine("Seu saldo inicial é de: R$ " + conta.consulta_saldo());

            conta.deposito(500);

            conta.sacar(1000);

            Console.WriteLine("Seu saldo inicial é de: R$ " + conta.consulta_saldo());

            conta.ajustar_limite(500);
        }


    }
}
