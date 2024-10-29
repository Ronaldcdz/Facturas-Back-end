using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Entities
{
    public class Factura : BaseModel
    {
        public int Id { get; set; }
        public required int ClienteId { get; set; }
        public required int NcfId { get; set; }
        public required DateTime Fecha { get; set; } = DateTime.Now;
        public double Subtotal { get; set; }
        public double Impuestos { get; set; }
        public double Total { get; set; }
        public string? Atencion { get; set; }
        public string? Proyecto { get; set; }
        public bool? Pagado { get; set; }

        // Relaciones
        public Cliente? Cliente { get; set; }
        public Ncf? Ncf { get; set; }
        public ICollection<DetalleFactura>? Productos { get; set; }

    }
}