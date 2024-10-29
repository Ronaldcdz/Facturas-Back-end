using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Entities
{
    public class TipoNcf : BaseModel
    {
        public int Id { get; set; }
        public required string Descripcion { get; set; }

        // Relaciones
        public ICollection<Ncf>? Ncfs { get; set; }
    }
}