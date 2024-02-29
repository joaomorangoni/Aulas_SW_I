using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampada
{
    public class Lampada
    {
        private bool Ligada { get; set; }
        private string? Cor { get; set; }
        private int Potencia { get; set; }

        public void ligar()
        {
            Ligada = true;
        }

        public void desligar()
        {
            Ligada = false;
        }

        public bool estaLigada()
        {
            return Ligada;        
        }

        public void maisPotencia()
        {
            Potencia = +12;
        }

        public void menosPotencia()
        {
            Potencia = -12;
        }

        public int qualPotencia()
        {
            return Potencia;
        }

        public void vermelho()
        {
            Cor = "Vermelho";
        }

        public void verde()
        {
            Cor = "Verde";
        }

        public void azul()
        {
            Cor = "Azul";
        }

        public string qualCor()
        {
            return Cor;
        }
    }
}
