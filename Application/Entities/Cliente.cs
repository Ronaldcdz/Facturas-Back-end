using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Entities
{
    public class Cliente : BaseModel
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Rnc { get; set; }
        public string? Direccion { get; set; }
        public required int CiudadId { get; set; }
        public string? Telefono { get; set; }
        // public string? Atencion { get; set; }
        // public string? Proyecto { get; set; }
        public string? Correo { get; set; }

        // Relaciones
        public ICollection<Factura>? Facturas { get; set; }
    }
}