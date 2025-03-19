using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen2
{
    class Program
    {
        static void Main()
        {
            List<Producto> productos = new List<Producto>
        {
            new Producto("Laptop", 1500m, 5, "Dell"),
            new Producto("Smartphone", 800m, 10, "Samsung"),
            new Producto("Tablet", 500m, 7, "Apple")
        };

            List<Cliente> clientes = new List<Cliente>
        {
            new Cliente("Juan Pérez", "juan@example.com", "123456789"),
            new Cliente("Ana Ruiz", "ana@example.com", "987654321"),
            new Cliente("Luis Gómez", "luis@example.com", "456123789")
        };

            List<Empleado> empleados = new List<Empleado>
        {
            new Empleado("Ana Gómez", "ana@empresa.com", "123456789", "Vendedor", 2000m),
            new Gerente("Carlos López", "carlos@empresa.com", "987654321", "Gerente General", 5000m, 1500m)
        };

            while (true)
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Crear nuevo cliente");
                Console.WriteLine("2. Realizar compra");
                Console.WriteLine("3. Ver diferencia de salario entre empleado y gerente");
                Console.WriteLine("4. Mostrar lista de empleados con sus salarios");
                Console.WriteLine("5. Mostrar inventario de productos");
                Console.WriteLine("6. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Correo: ");
                        string correo = Console.ReadLine();
                        Console.Write("Teléfono: ");
                        string telefono = Console.ReadLine();
                        clientes.Add(new Cliente(nombre, correo, telefono));
                        Console.WriteLine("Cliente creado exitosamente.");
                        break;

                    case "2":
                        try
                        {
                            int clienteIndex;
                            do
                            {
                                Console.WriteLine("Seleccione un cliente:");
                                for (int i = 0; i < clientes.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {clientes[i].Nombre}");
                                }
                                clienteIndex = int.Parse(Console.ReadLine()) - 1;
                            } while (clienteIndex < 0 || clienteIndex >= clientes.Count);

                            int productoIndex;
                            do
                            {
                                Console.WriteLine("Seleccione un producto:");
                                for (int i = 0; i < productos.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {productos[i].Nombre} - ${productos[i].Precio}");
                                }
                                productoIndex = int.Parse(Console.ReadLine()) - 1;
                            } while (productoIndex < 0 || productoIndex >= productos.Count);

                            Console.Write("Ingrese la cantidad a comprar: ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (productos[productoIndex].ReducirStock(cantidad))
                                clientes[clienteIndex].RegistrarCompra();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;

                    case "3":
                        var empleado = empleados[0];
                        var gerente = (Gerente)empleados[1];
                        Console.WriteLine(empleado);
                        Console.WriteLine(gerente);
                        Console.WriteLine($"Diferencia de salario: ${gerente.CalcularSalarioTotal() - empleado.CalcularSalarioTotal()}.");
                        break;

                    case "4":
                        foreach (var emp in empleados)
                        {
                            Console.WriteLine(emp);
                        }
                        break;

                    case "5":
                        foreach (var producto in productos)
                        {
                            Console.WriteLine(producto);
                        }
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
