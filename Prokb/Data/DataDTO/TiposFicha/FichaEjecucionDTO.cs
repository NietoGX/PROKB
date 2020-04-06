using System;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.DataDTO.TiposFicha
{
    class FichaEjecucionDTO : FichaNoConformicadDTO
    {
        
        public DateTime FechaEjecucion { get; set; }
        public int IdResponsableEjecucion { get; set; }
        public int IdPropuesta { get; set; }
        public int IdDecision { get; set; }
        public string Descripcion { get; set; }
        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
