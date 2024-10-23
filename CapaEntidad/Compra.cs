using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Proveedor IdProveedor { get; set; }
        public string TipoFactura { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public List <Detalle_Compra> DetalleCompra {  get; set; }
        public string FechaRegistro { get; set; }

    }
}
