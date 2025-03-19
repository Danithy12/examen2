using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Persona(string nombre, string correo, string telefono)
        {
            Nombre = nombre;
            Correo = correo;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Correo: {Correo}, Teléfono: {Telefono}";
        }
    }
}
