namespace Fotos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meu Album de fotos!");

            AlbumDeFotos p = new AlbumDeFotos();

            Console.WriteLine("Insira quantas páginas tem o seu album: ");
            p.NUMMMM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira quantas fotos vai por em seu álbum: ");
            p.Numerofotos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------");




        }
    }
}