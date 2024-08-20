using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            Plano plano1 = new Plano()
            {
                x1 = 0,
                y1 = 0,
                x2 = 4,
                y2 = 0,
                x3 = 0,
                y3 = 8,
            };

            plano1.calcularDistanciaBase();
            Console.WriteLine("La Base es de: " + plano1.Base);
            plano1.calcularDistanciaAltura();
            Console.WriteLine("La Altura es de: " + plano1.Altura);
            plano1.calcularArea();
            Console.WriteLine("El Area es de: " + plano1.Area);
            plano1.calcularPerimetro();
            Console.WriteLine("El Perimetro es de: " + plano1.Perimetro);

            Console.Read();
        }
    }
}
