using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    public class Cliente : Persona
    {
        public int ComprasRealizadas { get; private set; }

        public Cliente(string nombre, string correo, string telefono) : base(nombre, correo, telefono)
        {
            ComprasRealizadas = 0;
        }

        public void RegistrarCompra()
        {
            ComprasRealizadas++;
            Console.WriteLine($"Esta es tu compra número {ComprasRealizadas}");
        }
    }
}
