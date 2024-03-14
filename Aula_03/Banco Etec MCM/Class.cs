using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Conta
    {
        private string? Num_conta { get; set; }

        private float Saldo { get; set; }

        private float Limite { get; set; }

        private float Saldo_Limite { get; set; }

        public float consulta_saldo()
        {
            return Saldo;
        }

        public void deposito(float valor_deposito)
        {
            Saldo += valor_deposito;
            Console.WriteLine("Agora seu saldo é de R$ " + consulta_saldo());
        }

        public void sacar(float valor_saque)
        {
            if(valor_saque > Saldo_Limite)
            {
                Console.WriteLine("VOCÊ NÃO TEM SALDO SUFICIENTE!");
            }
            else
            {
                Saldo -= valor_saque;
                Console.WriteLine("Agora seu saldo é de R$ " + consulta_saldo());
            }
        }

        public void ajustar_limite(float valor_limite)
        {
            Limite = valor_limite;
            Console.WriteLine("Agora seu limite é de R$ " + Limite);
            Saldo_Limite = Limite + Saldo;
            Console.WriteLine("Seu saldo + limite é de R$ " + Saldo_Limite);
        }
    }
}
