using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    public class Gerente : Empleado
    {
        public decimal BonoAnual { get; set; }

        public Gerente(string nombre, string correo, string telefono, string cargo, decimal salario, decimal bonoAnual)
            : base(nombre, correo, telefono, cargo, salario)
        {
            BonoAnual = bonoAnual;
        }

        public override decimal CalcularSalarioTotal()
        {
            return Salario + BonoAnual;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Bono Anual: ${BonoAnual}";
        }
    }
}
