using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    public class Empleado : Persona
    {
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        public Empleado(string nombre, string correo, string telefono, string cargo, decimal salario) : base(nombre, correo, telefono)
        {
            Cargo = cargo;
            Salario = salario;
        }

        public virtual decimal CalcularSalarioTotal()
        {
            return Salario;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Cargo: {Cargo}, Salario: ${Salario}";
        }
    }
}
