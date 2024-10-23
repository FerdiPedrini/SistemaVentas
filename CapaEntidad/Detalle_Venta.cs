using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_Venta
    {
        public int IdDetalleVenta   { get; set; }
        public Producto producto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public string FechaRegistro { get; set; }

    }
}
