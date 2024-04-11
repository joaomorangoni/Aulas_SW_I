using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fotos
{
    public class AlbumDeFotos
    {
        public int NUMMMM;
        public int numeroTotalDePaginas
        {
            get
            {
                return NUMMMM;
            }

            set
            {
              
            }
        }

        public int numeroTotalDeFotos
        {
            get
            {
                return numeroTotalDePaginas * 2;
            }
        }

        private int numeroFotos;

        public int Numerofotos
        {
            get
            {
                return numeroFotos;
            }

            set
            {
                if (value < numeroTotalDeFotos)
                {
                    Console.WriteLine("\nSeu Album contém " + NUMMMM + " páginas");
                    Console.WriteLine("\nE seu album contém " + value + " fotos, com 2 em cada página");
                }
                else
                {
                    Console.WriteLine("A quantidade de fotos excedeu o limite, tente novamente.");
                }
            }


        }

    }
}
