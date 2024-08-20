using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Estudiante
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombresCompletos { get; set; }
        public int CodigodeEstudiante { get; set; }

        public void asignarNombreCompleto()
        {
            NombresCompletos = Nombres + " " + Apellidos;
        }
    }
}
