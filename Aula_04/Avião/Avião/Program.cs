namespace Aviao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aviao aviao = new Aviao();

            aviao.Marca = "Gol";
            aviao.Modelo = "737-700";

            aviao.Acelerar(10);
            aviao.Subir(220);

            Console.WriteLine($"A altura do avião é: {aviao.Altitude}m, A velocidade é: {aviao.Velocidade}km/h, A marca é: {aviao.Marca}, e o modelo é: {aviao.Modelo}");
        }
    }
}
