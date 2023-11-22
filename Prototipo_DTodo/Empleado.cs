using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_DTodo
{
    public class Empleado
    {
        public string Nombre { get; set; }

        public Empresa EmpresaAsociada { get; set; }

        public List<Alerta> Alertas { get; set; }

        public Empleado(string nombre, Empresa empresaAsociada)
        {
            Nombre = nombre;
            EmpresaAsociada = empresaAsociada;
            Alertas = new List<Alerta>();
        }

        public void CntProductosDisponibles()
        {
            EmpresaAsociada.verificarProductosDisponibles(this);
        }

        public void CntProductoEspecifico(string NombreProducto)
        {
            EmpresaAsociada.verificarProductoEspecifico(this, NombreProducto);
        }

        public void CrearAlerta(string nombre, int cantidad)
        {
            bool alerta_no_existente = verificar_alerta(nombre);

            if (alerta_no_existente)
            {
                Alerta alerta = new Alerta(nombre, cantidad);
                Alertas.Add(alerta);
            }
        }

        public bool verificar_alerta(string nombre)
        {
            foreach (Alerta alerta in Alertas)
            {
                if (alerta.Nombre == nombre)
                {
                    Console.WriteLine(alerta.Nombre + " ya existe!");
                    return false;
                }
            }

            return true;
        }

        public void CancelarAlerta(string nombre)
        {
            Alerta? alerta_deseada = null;

            foreach (Alerta alerta in Alertas)
            {
                if (alerta.Nombre == nombre)
                {
                    alerta_deseada = alerta;
                }
            }

            if (alerta_deseada != null)
            {
                Alertas.Remove(alerta_deseada);
                Console.WriteLine("Alerta eliminada efectivamente!");
            }
            else
            {
                Console.WriteLine("No existe ninguna alerta con este nombre!");
            }

        }

        public void ConfigurarAlerta(string nombre)
        {
            foreach (Alerta alerta in Alertas)
            {
                if (alerta.Nombre == nombre)
                {
                    int nueva_cantidad;
                    string nuevo_nombre;

                    // Nueva cantidad
                    Console.WriteLine("Introduce una nueva cantidad:");
                    nueva_cantidad = int.Parse(Console.ReadLine());

                    // Nuevo Nombre
                    Console.WriteLine("Introduce un nuevo nombre:");
                    nuevo_nombre = Console.ReadLine();

                    Console.WriteLine("La nueva cantidad es {0} y el nuevo nombre es {1}", nueva_cantidad, nuevo_nombre);

                    alerta.Nombre = nuevo_nombre;
                    alerta.Cantidad = nueva_cantidad;
                }
            }

        }
    }
}
