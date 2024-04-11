using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ÁreaQuadradoRetangulo
{
    public class Area
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double AreaTotal { get; set; }

        public string Calcular()
        {
            Console.WriteLine("Digite a base: ");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            Altura = Convert.ToDouble(Console.ReadLine());

            AreaTotal = Base * Altura;
            string tipo = "";

            if(Base == Altura)
            {
                tipo = " e isso é um: Quadrado";
            }
            else
            {
                 tipo = " e isso é um: Retângulo";
            }

            string resultado = "A área é: " + AreaTotal;
            resultado += tipo;

            return resultado;
        }

        public string Dados()
        {
            string info = "\nO valor do base é: " + Base;
            info += "\nO valor da altura é: " + Altura;

            return info;
        }
    }
}
