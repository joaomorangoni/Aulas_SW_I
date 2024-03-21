using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviao
{
    public class Aviao
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int Velocidade { get; set; }
        public int Altitude { get; set; }

        public void Subir(int m)
        {
            Altitude += m;
        }

        public void Descer(int m)
        {
            if (Altitude >= 0)
            {
                Altitude -= m;
            }
            else
            {
                Altitude = 0;
            }
        }

        public void Acelerar(int v)
        {
            Velocidade += v;
        }

        public void Reduzir(int v)
        {
            if (Velocidade >= 0)
            {
                Velocidade -= v;
            }
            else
            {
                Velocidade = 0;
            }
        }
    }
}
