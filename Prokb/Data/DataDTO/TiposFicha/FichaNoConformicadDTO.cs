using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prokb.Data.DataDTO.TiposFicha
{
    public class FichaNoConformicadDTO
    {
        public int Id { get; set; }
        public string FichaReferencia { get; set; }

        public string EmisorId { get; set; }

        public int ProveedorId { get; set; }

        public int ArticuloId { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaModificacion { get; set; }
        public int DecisionId { get; set; }
        public List<int> IncidenciasId { get; set; }
    }
}
