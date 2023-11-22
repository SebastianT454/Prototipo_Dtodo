using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_DTodo
{
    public class Empresa
    {
        public string Nombre { get; set; }

        public List<Empleado> Empleados { get; set; }

        public List<Producto> Productos { get; set; }

        public Empresa(string nombre)
        {
            Nombre = nombre;
            Empleados = new List<Empleado>();
            Productos = new List<Producto>();
        }

        public void ContratarEmpleado(string nombre)
        {
            Empleado empleado = new Empleado(nombre, this);
            Empleados.Add(empleado);
        }

        public void AgregarProducto(string nombre, int cantidad)
        {
            Producto producto = new Producto(nombre, cantidad);
            Productos.Add(producto);
        }

        public bool verificarEmpleado(Empleado empleado)
        {
            if (empleado.EmpresaAsociada == this)
            {
                Console.WriteLine("El empleado pertenece a la empresa!");
                return true;
            }
            
            return false;
        }

        public void verificarProductosDisponibles(Empleado empleado)
        {
            bool empleado_asociado = verificarEmpleado(empleado);

            if (empleado_asociado)
            {

                if(Productos.Count > 0) 
                {
                    Console.WriteLine("Hay stock en el inventario!");
                }
                else
                {
                    Console.WriteLine("No hay stock en el inventario!");
                }

            }
        }

        public void verificarProductoEspecifico(Empleado empleado, string NombreProducto)
        {
            bool empleado_asociado = verificarEmpleado(empleado);

            if (empleado_asociado)
            {
                foreach (Producto producto in Productos)
                {
                    if (producto.Nombre == NombreProducto) 
                    { 
                        if (producto.Cantidad > 0)
                        {
                            Console.WriteLine("Hay stock de este producto!");
                        }
                        else
                        {
                            Console.WriteLine("No hay stock de este producto");
                        }

                        return;
                    }
                }

            }
        }
    }
}
