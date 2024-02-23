namespace Lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // INSTÂNCIA DE UM OBJETO
            Lampada lampada1 = new Lampada();
            Lampada lampada2 = new Lampada();

            //ACESSANDO UM ATRIBUTO PUBLICO DO OBJETO
            lampada1.Ligada = true;
            lampada1.Potencia = 150;
            lampada1.Cor = "Vermelho";

            lampada2.Ligada = false;
            lampada2.Potencia = 100;
            lampada2.Cor = "Verde";

            //VISUALIZANDO OS VALORES DE ATRIBUTOS
            Console.WriteLine("***************************************");
            Console.WriteLine("ESSA É A LÂMPADA 1");
            Console.WriteLine("A lâmpada está Ligada? " + lampada1.Ligada);
            Console.WriteLine("A Potência da Lâmpada é: " + lampada1.Potencia);
            Console.WriteLine("A cor da Lâmpada é: " + lampada1.Cor);
            Console.WriteLine("***************************************");
            Console.WriteLine("ESSA É A LÂMPADA 2");
            Console.WriteLine("A lâmpada está Ligada? " + lampada2.Ligada);
            Console.WriteLine("A Potência da Lâmpada é: " + lampada2.Potencia);
            Console.WriteLine("A cor da Lâmpada é: " + lampada2.Cor);
            Console.WriteLine("***************************************");
        }
    }
}