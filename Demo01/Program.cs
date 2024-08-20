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
            
            Persona persona = new Persona();
            persona.Nombres = "Jared";
            persona.Apellidos = "Garcia";

            Profesor profesor = new Profesor
            {
                Nombres = "Hugo",
                Apellidos = "Torrico",
                Sueldo = 15000
            };

            Estudiante estudiante = new Estudiante
            {
                Nombres = "Jared",
                Apellidos = "Garcia",
                CodigodeEstudiante = 115080
            };

            persona.asignarNombreCompleto();
            Console.WriteLine("Bienvenido: " + persona.NombresCompletos);

            Console.Read();
        }
    }
}
