namespace Lampada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Criando um novo objeto da classe lâmpada (nova instancia)
            Lampada lamp1 = new Lampada();

            //Chamando o método pra ligar a lamp1
            lamp1.ligar();
            lamp1.maisPotencia();
            lamp1.azul();

            //Chamando o método para verificar se lamp1 está ligada
            Console.WriteLine("A Lâmpada está ligada? " + lamp1.estaLigada());
            Console.WriteLine("A Potencia da lâmpada é de " + lamp1.qualPotencia());
            Console.WriteLine("A Cor da Lâmpada é: " + lamp1.qualCor());



        }
    }
}