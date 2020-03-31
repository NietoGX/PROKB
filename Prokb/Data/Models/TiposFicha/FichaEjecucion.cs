using System;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.Models.TiposFicha
{
    public class FichaEjecucion : FichaNoConformidad
    {

        public DateTime FechaEjecucion { get; set; }
        public int ResponsableEjecucionId { get; set; }
        public virtual EmpresaAreaSeccionUsuario ResponsableEjecucion { get; set; }
        public bool EsDecision { get; set; }
        public int PropuestaEjecucionId { get; set; }
        public virtual TipoDecisionSeccion PropuestaEjecucion { get; set; }
        public int DecisionEjecucionId { get; set; }
        public virtual TipoDecisionSeccion DecisionEjecucion { get; set; }
        public string Descripcion { get; set; }
        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
