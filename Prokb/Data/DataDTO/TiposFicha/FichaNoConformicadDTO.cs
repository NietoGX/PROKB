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

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaModificacion { get; set; }
        
    }
}
