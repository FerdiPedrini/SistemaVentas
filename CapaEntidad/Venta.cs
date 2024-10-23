using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public Usuario usuario { get; set; }
        public string TipoFactura { get; set; }
        public string NumeroDocumento   { get; set; }
        public string NombreCliente { get; set; }
        public decimal MontoPago { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public List<Detalle_Venta> DetalleVenta { get; set; }
        public string FechaRegistros { get; set; }
        
    }
}
