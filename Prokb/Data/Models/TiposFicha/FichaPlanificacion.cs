using System;
using System.ComponentModel.DataAnnotations;

namespace Prokb.Data.Models.TiposFicha
{

    public class FichaPlanificacion : FichaNoConformidad
    {

        public DateTime FechaPlanificacion { get; set; }
        public int ResponsablePlanificacionId { get; set; }
        public virtual Usuario ResponsablePlanificacion { get; set; }
        public int DecisionPlanificacionId { get; set; }
        public virtual TipoDecisionSeccion DecisionPlanificacion { get; set; }
        public int CantidadDevuelta { get; set; }
        public int CantidadConforme { get; set; }
        public string GastosACargoDe { get; set; }
        public string ComentarioProveedor { get; set; }
        public string DescripcionDecision { get; set; }

        public bool Finalizada { get; set; }//define si esta rellenada o no
    }
}
