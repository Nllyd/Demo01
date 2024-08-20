using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class Rectangulo
    {

        public int Base { get; set; }
        public int Altura { get; set; }

        public int calcularArea()
        {
            return Base * Altura;
        }

        public int calcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
