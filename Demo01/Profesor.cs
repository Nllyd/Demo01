﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Profesor
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombresCompletos { get; set; }
        public int Sueldo { get; set; }

        public void asignarNombreCompleto()
        {
            NombresCompletos = Nombres + " " + Apellidos;
        }
    }
}
