using System;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.Models.TiposFicha
{
    public class FichaEjecucion : FichaNoConformidad
    {

        public DateTime FechaEjecucion { get; set; }
        public int ResponsableEjecucionId { get; set; }
        public Usuario ResponsableEjecucion { get; set; }
        public int IdPropuesta { get; set; }
        public TipoDecisionSeccion PropuestaEjecucion { get; set; }
        public int IdDecisionEjecucion { get; set; }
        public TipoDecisionSeccion DecisionEjecucion { get; set; }
        public string Descripcion { get; set; }
        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
