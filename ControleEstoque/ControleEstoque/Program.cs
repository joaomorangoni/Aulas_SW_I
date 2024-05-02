namespace ControleEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(5, "Pochita_Plushie", 0, 3900);
            p.imprimir();
            p.entrada(20);
            p.imprimir();
            p.venda(5);
            p.imprimir();
        }
    }
}