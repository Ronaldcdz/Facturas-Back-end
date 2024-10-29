using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Entities
{
    public class Producto : BaseModel
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public double Precio { get; set; }
        public double Impuesto { get; set; }
 
        // Relaciones
        public ICollection<DetalleFactura>? Facturas { get; set; }
    }
}