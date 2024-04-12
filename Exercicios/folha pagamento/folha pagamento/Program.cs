namespace folha_pagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pagamento p = new Pagamento();
            p.Nome = "João";
            p.Sal = 8700;
            p.HED = 1;
            p.HEN = 4;
            p.ND = 0;
            p.Fal = 47;
            p.DE = 5;
            p.REF = 8;
            p.Val = 1;
            Console.WriteLine(p.FolhaDePagamento());
        }
    }
}