using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Entities
{
    public class DetalleFactura : BaseModel
    {
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Subtotal { get; set; }
        
        
        // Relaciones
        public Producto? Producto { get; set; }
        public Factura? Factura { get; set; }
    }
}