using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLDeberSemana6.Vistas
{
    internal class Producto
    {
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public int minimo { get; set; }
        public int maximo { get; set; }
    }
}
