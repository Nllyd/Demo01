using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class Plano
    {
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int x3 { get; set; }

        public int y1 { get; set; }
        public int y2 { get; set; }
        public int y3 { get; set; }

        public int Base { get; set; }
        public int Altura { get; set; }

        public int valorBase1 { get; set; }
        public int valorBase2 { get; set; }
        public double calculo1 { get; set; }

        public int valorAltura1 { get; set; }
        public int valorAltura2 { get; set; }
        public double calculo2 { get; set; }

        public int Area { get; set; }
        public int Perimetro { get; set; }
        public void calcularDistanciaBase()
        {
            valorBase1 = x2 - x1;
            valorBase2 = y2 - y1;

            valorBase1 = (int)Math.Pow(valorBase1, 2);
            valorBase2 = (int)Math.Pow(valorBase2, 2);
            calculo1 = valorBase1 + valorBase2;

            Base = (int)Math.Sqrt(calculo1);
        }

        public void calcularDistanciaAltura()
        {
            valorAltura1 = x3 - x1;
            valorAltura2 = y3 - y1;

            valorAltura1 = (int)Math.Pow(valorAltura1, 2);
            valorAltura2 = (int)Math.Pow(valorAltura2, 2);
            calculo2 = valorAltura1 + valorAltura2;

            Altura = (int)Math.Sqrt(calculo2);
        }
        public void calcularArea()
        {
            Area = Base * Altura;
        }

        public void calcularPerimetro()
        {
            Perimetro = 2 * (Base + Altura);
        }
    }
}
