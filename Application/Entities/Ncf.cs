using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Entities
{
    public class Ncf : BaseModel
    {
        public int Id { get; set; }
        public int TipoNcfId { get; set; }
        public required string NumeroNcf { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public int Estado { get; set; }

        // Relaciones
        public Factura? Factura{ get; set; }
        public TipoNcf? TipoNcf{ get; set; }

    }
}