using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    public class Producto
    {
        private string nombre;
        private decimal precio;
        private int stock;
        private string marca;

        public Producto(string nombre, decimal precio, int stock, string marca)
        {
            this.nombre = nombre;
            Precio = precio;
            Stock = stock;
            this.marca = marca;
        }

        public string Nombre => nombre;
        public decimal Precio
        {
            get => precio;
            set
            {
                if (value < 0) throw new ArgumentException("El precio no puede ser negativo.");
                precio = value;
            }
        }

        public int Stock
        {
            get => stock;
            set
            {
                if (value < 0) throw new ArgumentException("El stock no puede ser negativo.");
                stock = value;
            }
        }

        public string Marca => marca;

        public bool ReducirStock(int cantidad)
        {
            if (cantidad <= 0) throw new ArgumentException("Cantidad inválida.");
            if (cantidad > stock)
            {
                Console.WriteLine("Lo sentimos, no tenemos stock de ese producto.");
                return false;
            }
            stock -= cantidad;
            return true;
        }

        public override string ToString()
        {
            return $"{Nombre} - {Marca} - Precio: ${Precio} - Stock: {Stock}";
        }
    }
}
