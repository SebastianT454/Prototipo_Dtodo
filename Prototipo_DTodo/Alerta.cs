using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_DTodo
{
    public class Alerta
    {
        public string Nombre { get; set; }

        public int Cantidad { get; set; }

        public Alerta(string nombre, int cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }
    }
}
