using System;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.DataDTO.TiposFicha
{
    class FichaLogisticaDTO : FichaNoConformicadDTO
    {
        
        public DateTime FechaLogistica { get; set; }
        public UsuarioDTO ResponsableLogistica { get; set; }
        public int ResponsableLogisticaId { get; set; }
        public DecisionDTO Decision { get; set; }
        public int DecisionId { get; set; }
        public string DescripcionLogistica { get; set; }
        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
